namespace CircleImageDemo.Models
{
    public class Contact : ObservableObject
    {
        #region Properties

        private string name;

        public string Name
        {
            get => name;
            set => RaisePropertyChanged(ref name, value);
        }

        private string photoUrl;

        public string PhotoUrl
        {
            get => photoUrl;
            set => RaisePropertyChanged(ref photoUrl, value);
        }


        private string email;

        public string Email
        {
            get => email;
            set => RaisePropertyChanged(ref email, value);
        }

        private string comment;

        public string Comment
        {
            get => comment;
            set => RaisePropertyChanged(ref comment, value);
        }

        private bool isBookmarked;

        public bool IsBookmarked
        {
            get => isBookmarked;
            set => RaisePropertyChanged(ref isBookmarked, value);
        }
        #endregion
    }
}

