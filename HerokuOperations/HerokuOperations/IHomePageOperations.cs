using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuOperations
{
    public interface IHomePageOperations
    {
        string getTitle();
        string getSubTitle();
        string getGithubLink();
        string[] getAvailableExamples();

        void navigateTo(string exampleName);
    }
}
