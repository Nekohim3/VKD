using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ReactiveUI;

namespace VKD.ViewModels
{
    public class MainWindowViewModel :ReactiveObject
    {
        public MainWindowViewModel()
        {
            LoadTest();
        }

        public void LoadTest()
        {
            var ts   = File.ReadAllText("users.txt");
            var root = JsonConvert.DeserializeObject<Root>(ts);
        }
    }
}
