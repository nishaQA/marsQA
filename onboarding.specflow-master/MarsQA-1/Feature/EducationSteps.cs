using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        [Given(@"The sellers' is in the Education page")]
        public void GivenTheSellersIsInTheEducationPage()
        {
            Education.EducationTab.Click();
        }
        
        [Then(@"The sellers' able to view  Education has been Added")]
        public void ThenTheSellersAbleToViewEducationHasBeenAdded()
        {
            Education.AddNewEduStep();
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The sellers' able to see Education has been  Updated")]
        public void ThenTheSellersAbleToSeeEducationHasBeenUpdated()
        {
            Education.UpdateEduStep();
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should be Education has been Deleted")]
        public void ThenTheMessageShouldBeEducationHasBeenDeleted()
        {
            Education.DeleteEdustep();
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should appear  The inforfamtion is already exists")]
        public void ThenTheMessageShouldAppearTheInforfamtionIsAlreadyExists()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"The message should display Please enter all fields")]
        public void ThenTheMessageShouldDisplayPleaseEnterAllFields()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
