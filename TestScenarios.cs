using NUnit.Framework;
using RIBCCS.Pages;

namespace RIBCCS
{
    public class Tests : TestSetup
    {
        [Test]
        public void CombinedScript()
        {
            string itemToDrag = "High Tatras 2";
            DragAndDropPage dragAndDropPage = new DragAndDropPage(driver);

            dragAndDropPage.DragItem(itemToDrag);

            string countryName = "South Africa";
            DropDownMenuPage dropDownMenuPage = new DropDownMenuPage(driver);
            
            Navigate(dropDownMenuPage.Link);
            dropDownMenuPage.SelectCountry(countryName);

            string name = "TestName";
            string email = "test@email.com";
            string website = "www.test.com";
            string experience = "3-5";
            string comment = "This is a test comment";

            SamplePage samplePage = new SamplePage(driver);
            Navigate(samplePage.Link);
            samplePage.FillInSamplePage(name, email, website, experience, comment);
        }

        [TestCase("High Tatras 2")]
        public void Scenario1(string itemToDrag)
        {
            DragAndDropPage dragAndDropPage = new DragAndDropPage(driver);

            dragAndDropPage.DragItem(itemToDrag);
        }

        [TestCase("South Africa")]
        public void Scenario2(string countryName)
        {
            DropDownMenuPage dropDownMenuPage = new DropDownMenuPage(driver);

            Navigate(dropDownMenuPage.Link);
            dropDownMenuPage.SelectCountry(countryName);
        }

        [TestCase("TestName", "test@email.com", "www.test.com", "3-5", "This is a test comment")]
        public void Scenario3(string name, string email, string website, string experience, string comment)
        {
            SamplePage samplePage = new SamplePage(driver);

            Navigate(samplePage.Link);
            samplePage.FillInSamplePage(name, email, website, experience, comment);
        }
    }
}