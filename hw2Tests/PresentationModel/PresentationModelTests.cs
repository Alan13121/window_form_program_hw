using hw2.PresentationModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Drawing;

namespace hw2.PresentationModel.Tests
{
    [TestClass]
    public class PresentationModelTests
    {
        private PresentationModel _presentationModel;

        [TestInitialize]
        public void Initialize()
        {
            var mockModel = new Model(); // 替换为实际 Model 实例或模拟对象
            _presentationModel = new PresentationModel(mockModel);
        }

        [TestMethod]
        public void TestShapeComboBoxIndexChanged_ValidIndex_ShouldSetColorBlack()
        {
            _presentationModel.ShapeComboBoxIndexChanged(0); // 传入有效索引
            Assert.AreEqual(Color.Black, _presentationModel.ShapeComboxTextColor);
        }

        [TestMethod]
        public void TestShapeComboBoxIndexChanged_InvalidIndex_ShouldSetColorRed()
        {
            _presentationModel.ShapeComboBoxIndexChanged(-1); // 无效索引
            Assert.AreEqual(Color.Red, _presentationModel.ShapeComboxTextColor);
        }

        [TestMethod]
        public void TestTextTextBoxTextChanged_ValidText_ShouldSetColorBlack()
        {
            _presentationModel.TextTextBoxTextChanged("Valid Text");
            Assert.AreEqual(Color.Black, _presentationModel.TextTextColor);
        }

        [TestMethod]
        public void TestTextTextBoxTextChanged_EmptyText_ShouldSetColorRed()
        {
            _presentationModel.TextTextBoxTextChanged("");
            Assert.AreEqual(Color.Red, _presentationModel.TextTextColor);
        }

        [TestMethod]
        public void TestXTextBoxTextChanged_ValidNumber_ShouldSetColorBlack()
        {
            _presentationModel.XTextBoxTextChanged("123.45");
            Assert.AreEqual(Color.Black, _presentationModel.XTextColor);
        }

        [TestMethod]
        public void TestXTextBoxTextChanged_InvalidNumber_ShouldSetColorRed()
        {
            _presentationModel.XTextBoxTextChanged("Invalid");
            Assert.AreEqual(Color.Red, _presentationModel.XTextColor);
        }
        [TestMethod]
        public void TestYTextBoxTextChanged_InvalidNumber_ShouldSetColorRed()
        {
            _presentationModel.YTextBoxTextChanged("Invalid");
            Assert.AreEqual(Color.Red, _presentationModel.YTextColor);
        }
        [TestMethod]
        public void TestHeightTextBoxTextChanged_InvalidNumber_ShouldSetColorRed()
        {
            _presentationModel.HeightTextBoxTextChanged("Invalid");
            Assert.AreEqual(Color.Red, _presentationModel.HeightTextColor);
        }
        [TestMethod]
        public void TestWidthTextBoxTextChanged_InvalidNumber_ShouldSetColorRed()
        {
            _presentationModel.WidthTextBoxTextChanged("Invalid");
            Assert.AreEqual(Color.Red, _presentationModel.WidthTextColor);
        }



        


        

        [TestMethod]
        public void TestCheckAllCorrect_AllValid_ShouldEnableAddButton()
        {
            _presentationModel.ShapeComboBoxIndexChanged(0);
            _presentationModel.TextTextBoxTextChanged("Valid Text");
            _presentationModel.XTextBoxTextChanged("123");
            _presentationModel.YTextBoxTextChanged("456");
            _presentationModel.HeightTextBoxTextChanged("10");
            _presentationModel.WidthTextBoxTextChanged("20");

            _presentationModel.CheckAllCorrect();

            Assert.IsTrue(_presentationModel.IsAddButtonEnabled);
        }

        [TestMethod]
        public void TestCheckAllCorrect_InvalidInput_ShouldDisableAddButton()
        {
            _presentationModel.ShapeComboBoxIndexChanged(-1); // 无效的 ComboBox 索引
            _presentationModel.TextTextBoxTextChanged("");
            _presentationModel.XTextBoxTextChanged("123");
            _presentationModel.YTextBoxTextChanged("456");
            _presentationModel.HeightTextBoxTextChanged("10");
            _presentationModel.WidthTextBoxTextChanged("20");

            _presentationModel.CheckAllCorrect();

            Assert.IsFalse(_presentationModel.IsAddButtonEnabled);
        }
    }
}