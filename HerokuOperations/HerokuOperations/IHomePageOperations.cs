using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuOperations
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHomePageOperations
    {
        string getTitle();
        string getSubTitle();
        string getGithubLink();
        string[] getAvailableExamples();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleName"></param>
        void navigateTo(string exampleName);
    }
}
