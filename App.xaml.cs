using dpullaguaris5b.Utils;

namespace dpullaguaris5b
{
    public partial class App : Application
    {
        public static PersonRepository personRepo;
        public App(PersonRepository personRepository)
        {
            InitializeComponent();

            MainPage = new  Views.Principal();
            personRepo=personRepository;
        }
    }
}
