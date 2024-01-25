using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReactiveUI;

namespace VKD
{
    [JsonObject]
    public class Root : ReactiveObject
    {
        private ObservableCollection<Girl> _users;
        public ObservableCollection<Girl> Users
        {
            get => _users;
            set => this.RaiseAndSetIfChanged(ref _users, value);
        }
    }

    [JsonObject]
    public class Girl : ReactiveObject
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => this.RaiseAndSetIfChanged(ref _id, value);
        }

        private Extra _extra;
        public Extra Extra
        {
            get => _extra;
            set => this.RaiseAndSetIfChanged(ref _extra, value);
        }

        [JsonProperty(PropertyName = "last_active_at")]
        private DateTime _lastActive;
        public DateTime LastActive
        {
            get => _lastActive;
            set => this.RaiseAndSetIfChanged(ref _lastActive, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }

        private int _age;
        public int Age
        {
            get => _age;
            set => this.RaiseAndSetIfChanged(ref _age, value);
        }

        [JsonProperty(PropertyName = "is_verify")]
        private bool _isVerify;
        public bool IsVerify
        {
            get => _isVerify;
            set => this.RaiseAndSetIfChanged(ref _isVerify, value);
        }

        [JsonProperty(PropertyName = "is_premium_enabled")]
        private bool _isPremium;
        public bool IsPremium
        {
            get => _isPremium;
            set => this.RaiseAndSetIfChanged(ref _isPremium, value);
        }

        private Form _form;
        public Form Form
        {
            get => _form;
            set => this.RaiseAndSetIfChanged(ref _form, value);
        }

        [JsonProperty(PropertyName = "form_extension")]
        private FormExtension _formExtension;
        public FormExtension FormExtension
        {
            get => _formExtension;
            set => this.RaiseAndSetIfChanged(ref _formExtension, value);
        }
    }

    [JsonObject]
    public class Form : ReactiveObject
    {
        private string _about;
        public string About
        {
            get => _about;
            set => this.RaiseAndSetIfChanged(ref _about, value);
        }
        private string _alcohol;
        public string Alcohol
        {
            get => _alcohol;
            set => this.RaiseAndSetIfChanged(ref _alcohol, value);
        }
        private string _books;
        public string Books
        {
            get => _books;
            set => this.RaiseAndSetIfChanged(ref _books, value);
        }

        private string _education;
        public string Education
        {
            get => _education;
            set => this.RaiseAndSetIfChanged(ref _education, value);
        }

        private string _family;
        public string Family
        {
            get => _family;
            set => this.RaiseAndSetIfChanged(ref _family, value);
        }
        private int _height;
        public int Height
        {
            get => _height;
            set => this.RaiseAndSetIfChanged(ref _height, value);
        }

        private ObservableCollection<string> _interests;
        public ObservableCollection<string> Interests
        {
            get => _interests;
            set => this.RaiseAndSetIfChanged(ref _interests, value);
        }
        
        private string _kids;
        public string Kids
        {
            get => _kids;
            set => this.RaiseAndSetIfChanged(ref _kids, value);
        }

        private ObservableCollection<string> _labels;
        public ObservableCollection<string> Labels
        {
            get => _labels;
            set => this.RaiseAndSetIfChanged(ref _labels, value);
        }

        private string _movies;
        public string Movies
        {
            get => _movies;
            set => this.RaiseAndSetIfChanged(ref _movies, value);
        }

        private string _smoking;
        public string Smoking
        {
            get => _smoking;
            set => this.RaiseAndSetIfChanged(ref _smoking, value);
        }

        private string _sport;
        public string Sport
        {
            get => _sport;
            set => this.RaiseAndSetIfChanged(ref _sport, value);
        }

        private string _target;
        public string Target
        {
            get => _target;
            set => this.RaiseAndSetIfChanged(ref _target, value);
        }

        private string _work;
        public string Work
        {
            get => _work;
            set => this.RaiseAndSetIfChanged(ref _work, value);
        }
    }

    [JsonObject]
    public class FormExtension : ReactiveObject
    {
        private ObservableCollection<Artist> _artists;
        public ObservableCollection<Artist> Artists
        {
            get => _artists;
            set => this.RaiseAndSetIfChanged(ref _artists, value);
        }
    }

    [JsonObject]
    public class Extra : ReactiveObject
    {
        private int _distance;
        public int Distance
        {
            get => _distance;
            set => this.RaiseAndSetIfChanged(ref _distance, value);
        }
    }

    [JsonObject]
    public class Artist : ReactiveObject
    {
        private string _id;
        public string Id
        {
            get => _id;
            set => this.RaiseAndSetIfChanged(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }
    }
}
