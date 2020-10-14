using CircleImageDemo.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace CircleImageDemo
{
    public class MainViewModel : ObservableObject
    {
        #region Properties
        private ObservableCollection<Contact> contacts;

        public ObservableCollection<Contact> Contacts
        {
            get => contacts;
            set => RaisePropertyChanged(ref contacts, value);
        }

        private string placeholderImage;

        public string PlaceholderImage
        {
            get => placeholderImage;
            set => RaisePropertyChanged(ref placeholderImage, value);
        }

        public int BookmarkedCount => Contacts.Count(c => c.IsBookmarked);
        #endregion

        #region Commands
        public ICommand SwitchBookmarkCommand { get; set; }
        #endregion

        public MainViewModel()
        {
            PlaceholderImage = "avatar_placeholder.png";

            SwitchBookmarkCommand = new Command<Contact>((contact) =>
            {
                if (contact != null)
                {
                    contact.IsBookmarked = !contact.IsBookmarked;
                    RaisePropertyChanged(nameof(BookmarkedCount));
                }
            });

            Contacts = new ObservableCollection<Contact>
            {
                new Contact {
                    Name= "Osu",
                    PhotoUrl="https://static.diverseui.com/female-57.jpg",
                    Comment="Photo chargée à partir d'une url",
                    Email = "osu@mymail.jp",
                    IsBookmarked = true
                },
                new Contact {
                    Name = "Anders",
                    PhotoUrl= "anders.png", Comment = "Photo en tant que ressource locale de l'application",
                    Email = "contact@anders.moc",
                    IsBookmarked=false
                },
                new Contact {
                    Name = "Anonymous",
                    Comment = "Aucune photo renseignée",
                    Email="ano@nym.ous",
                    IsBookmarked= false
                },
                            new Contact {
                    Name = "Wrongurlman",
                    PhotoUrl = "https://static.diverseui.com/oops404fsqgsgd.jpg",
                    Comment= "L'url de la photo retourne une erreur 404",
                    Email="wrong@url.man",
                    IsBookmarked=true
                },
                new Contact {
                    Name = "Unkownguy",
                    PhotoUrl = "https://abadurl/that/is/not/available",
                    Comment= "L'url est inaccessible",
                    Email="unknown@url.guy",
                    IsBookmarked=true
                }
            };
        }
    }
}