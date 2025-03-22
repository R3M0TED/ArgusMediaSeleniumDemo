using OpenQA.Selenium.Support.Extensions;

namespace SeleniumWebDriverExamples.Runtime
{
    sealed class ScreenshotUtilities
    {
        public static string GetScreenshotFolderPath()
        {
            string dateTimeFolderName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string runFolderPath = Path.Combine(GetMainFolder(), dateTimeFolderName);

            return runFolderPath;
        }

        public static void TakeFailureScreenshots(IEnumerable<TestParticipant> testParticipants, string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var subFolderPath = CreateSubFolder(folderPath, TestContext.CurrentContext.Test.Name);

            foreach (var testParticipant in testParticipants)
            {
                var screenshot = testParticipant.Driver.TakeScreenshot();

                screenshot.SaveAsFile(Path.Combine(subFolderPath, $"{testParticipant.Id}.png"));
            }
        }


        private static string CreateSubFolder(string mainFolderPath, string name)
        {
            var subFolderPath = Path.Combine(mainFolderPath, name);
            if (!Directory.Exists(subFolderPath))
            {
                Directory.CreateDirectory(subFolderPath);
            }

            return subFolderPath;
        }

        private static string GetMainFolder()
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "FailureScreenshots");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }
    }
}
