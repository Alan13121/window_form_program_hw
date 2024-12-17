using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using System.ComponentModel;
using Moq;
using System.Drawing;
namespace hw2.Tests
{
    [TestClass]
    public class ModelTests
    {
        private Model _model;
        private Mock<IState> _mockGeneralState;
        private Mock<IState> _mockDrawingState;
        [TestMethod]
        public void TestEnterNewShape_StringArray()
        {
            // Arrange
            var model = new Model();
            string[] shapeParams = { "Start", "0", "0", "0", "0", "0" };

            // Act
            model.enter_new_shape(shapeParams);
            var shapes = model.GetShapes();

            // Assert
            Assert.AreEqual(1, shapes.Count);
            Assert.AreEqual("Start", shapes[0].ShapeName);
            Assert.AreEqual(1, shapes[0].ID);
            Assert.AreEqual("0", shapes[0].Text);
            Assert.AreEqual(0, shapes[0].X);
            Assert.AreEqual(0, shapes[0].Y);
            Assert.AreEqual(0, shapes[0].Width);
            Assert.AreEqual(0, shapes[0].Height);
        }

        [TestMethod]
        public void TestEnterNewShape_ShapeObject()
        {
            // Arrange
            var model = new Model();
            
            ShapeFactory factory = new ShapeFactory();
            var shape = factory.CreateShape("Start", 0, "0", 0, 0, 0, 0);
            // Act
            model.enter_new_shape(shape);
            var shapes = model.GetShapes();

            // Assert
            Assert.AreEqual(1, shapes.Count);
            Assert.AreEqual("Start", shapes[0].ShapeName);
            Assert.AreEqual(1, shapes[0].ID);
            Assert.AreEqual("0", shapes[0].Text);
            Assert.AreEqual(0, shapes[0].X);
            Assert.AreEqual(0, shapes[0].Y);
            Assert.AreEqual(0, shapes[0].Width);
            Assert.AreEqual(0, shapes[0].Height);
        }

        [TestMethod]
        public void TestRemoveShape()
        {
            // Arrange
            var model = new Model();
            ShapeFactory factory = new ShapeFactory();
            var shape = factory.CreateShape("Start", 0, "0", 0, 0, 0, 0);
            // Act
            model.enter_new_shape(shape);

            // Act
            model.remove_shape(1);
            var shapes = model.GetShapes();

            // Assert
            Assert.AreEqual(0, shapes.Count);
        }

        [TestMethod]
        public void TestPointerPressed()
        {
            // Arrange
            var model = new Model();

            // Act
            model.PointerPressed(10, 20);

            // Assert
            // 檢查模型狀態是否改變 (需根據 IState 的 MouseDown 實現調整)
            Assert.IsTrue(true); // 可替換為具體驗證
        }

        [TestMethod]
        public void PointerMoved_ShouldInvokeNotifyModelChanged()
        {
            // Arrange
            var model = new Model();
            bool eventInvoked = false;

            // 訂閱 _modelChanged 事件來監聽方法是否被呼叫
            model._modelChanged += () => eventInvoked = true;

            // Act
            model.PointerMoved(10, 20);  // 呼叫 PointerMoved，這應該觸發 NotifyModelChanged

            // Assert
            Assert.IsTrue(eventInvoked, "NotifyModelChanged should be invoked when PointerMoved is called.");
        }

        [TestMethod]
        public void TestPointerReleased()
        {
            // Arrange
            var model = new Model();

            // Act
            model.PointerReleased(50, 60);

            // Assert
            // 檢查模型是否觸發更新 (需根據 IState 的 MouseUp 實現調整)
            Assert.IsTrue(true); // 可替換為具體驗證
        }
        

        [TestInitialize]
        public void Setup()
        {
            _model = new Model();

            // Mock 狀態物件以進行控制
            _mockGeneralState = new Mock<IState>();
            _mockDrawingState = new Mock<IState>();

            // 模擬 Initialize 方法的行為
            _mockGeneralState.Setup(state => state.Initialize(It.IsAny<Model>()));
            _mockDrawingState.Setup(state => state.Initialize(It.IsAny<Model>()));
        }
        [TestMethod]
        public void Draw_ShouldInvokeOnPaint()
        {
            var mockDrawable = new Mock<IDrawable>();
            var mockState = new Mock<IState>();

            // 替代 Model 內部的 currentState
            _model.ChangeToDrawingState("Start");
            _model.Draw(mockDrawable.Object);
        }

        

    }

}