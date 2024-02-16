using System;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Blog.Logic;

namespace Blog.App
{
    class Blog
    {
        // Fields
        private List<Blogs> _blogs;
        private List<Authors> _authors;
        private List<Users> _users;

        // Constructor.
        public Blog()
        {
            this._blogs = new List<Blogs>();
            this._authors = new List<Authors>();
            this._users = new List<Users>();

            //_authors.Add(new Authors("Jessirae Bufford", 9.7, "Jessirae.Bufford", "jessiebuff@nope.com", "password", "9159159159"));
        }

        public void Menu()
        {
        try
            {
                // in about me on portfolio, dont even talk about tech, talk bout things i do as hobbies outside of work, talk abuot my characteristics. talk about me! Introduce and describe myself.
                // Practice like I am going to present to the client
                // intro, what is my project, whats it suppossed to do, talk about the requirements. Then do a demo, 3-5 minutes
                // **program start
                // **desearialize my lists, user and blogs
                string path2 = @".\..\TextFile.txt";
                string path = @".\..\WriteFile.txt";

                    
                List<Authors> user = new List<Authors>();
                
                List<Blogs> sBlog = new List<Blogs>();
                string val;
                int choice = -1;
                Console.WriteLine("\n\n\nWelcome to your Journal Buddy!\n");
                Console.WriteLine("Do you have an account with us? (y/n): ");
                while(choice == -1){
                    val = Console.ReadLine();
                    //val.ToLower();
                    string decision = val.ToString();
                    decision = decision.ToLower();
                    //Console.WriteLine(decision);
                    // if(decision == 'n'' || decision != "y" )
                    // {
                    //     Console.WriteLine("Invalid selection. Please type either 'y' for YES or 'n' for NO, then press Enter.");

                    // }
                    // else if (decision == "n")
                    if(decision == "n")
                    {
                        string userName;
                        string email;
                        string password;
                        string phoneNumber;
                        Console.WriteLine("\nPlease enter a username: ");
                        userName = Console.ReadLine();
                        Console.WriteLine("\nPlease enter a password: ");
                        password = Console.ReadLine();
                        Console.WriteLine("\nPlease enter your email: ");
                        email = Console.ReadLine();
                        Console.WriteLine("\nPlease enter your phone number: ");
                        phoneNumber = Console.ReadLine();
                        
                        do
                        {
                            Console.WriteLine("\n\n\n\n\nYou can:");
                            Console.WriteLine("1 - Add a new journal entry.");
                            Console.WriteLine("2 - See all journal entries.");
                            Console.WriteLine("3 - Exit Journal Buddy.");
                            Console.WriteLine("4 - Deserialize.");
                            Console.WriteLine("\nYour selection: ");
                            val = Console.ReadLine();
                            choice = Convert.ToInt32(val);

                            switch(choice)
                            {
                                case 1:
                                    string blogTitle;
                                    string blogBody;
                                    string name;
                                    DateTime todaysDate;
                                    double rating = 0.0;
                                    Console.WriteLine("\nPlease type your full name then press Enter: ");
                                    name = Console.ReadLine();
                                    Console.WriteLine("\nTitle your journal: ");
                                    blogTitle = Console.ReadLine();
                                    Console.WriteLine("\nStart writing your journal and only press enter when you are ready to publish and save your journal: \n");
                                    blogBody = Console.ReadLine();
                                    Console.WriteLine("\n\n\nYour journal has now been saved!\n");
                                    todaysDate = DateTime.Today;
                                    Console.WriteLine("\t\t\tJournal Title: "+blogTitle);
                                    Console.WriteLine("\n" + blogBody);
                                    user.Add(new Authors(name, rating, userName, email, password, phoneNumber));
                                    Blogs aBlog = new Blogs(todaysDate, name, blogTitle, blogBody);
                                    //sBlog.Add(new Blogs(todaysDate, name, blogTitle, blogBody));
                                    Console.WriteLine("Seriallizing your last journal entry...");
                                    //Serialize(aBlog, path2);   

                                    //aBlog.Add(new Blogs(todaysDate, name, blogTitle, blogBody));
                                    var sb = new StringBuilder();
                                    foreach(Authors a in user)
                                    {
                                        sb.AppendLine(a.ToString());
                                    }
                                    Console.WriteLine("\t\t\t---------- Author ----------\n\t\t\tAuthor: " + name + "\n\t\t\tDate created: " + todaysDate);
                                    // return sb.ToString();

                                    //WRITE TO FILE
                                    Serialize(aBlog, path2);
                                    WriteFile(aBlog, path);

                                    break;
                                case 2:
                                    ReadFile(path);
                                    break;
                                case 3:
                                    
                                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\nClosing your Journal Buddy. Goodbye.");
                                    break;
                                case 4:
                                    Console.WriteLine("Deserializing your last journal entry...");
                                    Console.WriteLine("\nResult:\n");
                                    Blogs NewBlog = DeserializeXML(path2);
                                    Console.WriteLine(NewBlog.ToString());
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice, please try again.");
                                    break;
                            }
                        } while(choice!=3);
                        // generate a new user and save into user object
                    }
                    else
                    {
                        // ask for username and password
                        // check to see if this combination exists in user object
                        // if it doesn't, inform them and allow them to try again
                        // or exit the application
                        Console.WriteLine("Functionality under development");
                    }
                }



                
                
                    // create a menu
                        // MENU:
                            // $CREATE USER
                            // OR
                            // $LOGIN
                //  log in, if no login exists, create new user
                //  send data to user list
                //  user can:
                //      create a blog
                // if user creates blog, send to blog list
                //      associate user to blog in list
                //      user can have a list of blogs
                // at end of program, searialize list of user and blogs
                // when program starts again, go to top and repeat
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Methods
        public string GetAuthorsInfo()
        {
            var sb = new StringBuilder();
            foreach(Authors a in _authors)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }

        static void WriteFile(Blogs aBlog, string path)
        {
            // display/confirm the object
            Console.WriteLine(aBlog.ToString());

            // save to a file as text
            Console.WriteLine("Writing to file...");
            string[] text = {aBlog.ToString()};

            if( File.Exists(path))
            {
                //Console.WriteLine(text);
                File.AppendAllLines(path,text);
            }
            else
            {
                File.WriteAllLines(path, text); // WriteAllLines requires an IEnumerable (a collection) of strings
            // File.WriteLine(path, <string>); // WriteLine will operate on a single string...
            }
        }
        static void Serialize(Blogs aBlog, string path)
        {
            // convert/serialize the object
            Console.WriteLine(aBlog.SerializeXML());

            // save the serialized object to a file
            string[] text1 = {aBlog.SerializeXML()};
            File.WriteAllLines(path, text1);
        }

        static void ReadFile(string path)
        {
            Console.WriteLine("Reading from file...");
            // read from the file
            if(File.Exists(path))
            {
                string[] readText = File.ReadAllLines(path);
                foreach (string s in readText)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }

        static Blogs DeserializeXML(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Blogs));
            Blogs B = new Blogs();
            if (!File.Exists(path))
            {
                Console.WriteLine("File Not Found");
                return null;
            }
            else
            {
                using StreamReader reader = new StreamReader(path);
                var record = (Blogs)serializer.Deserialize(reader);
                if (record is null)
                {
                    throw new InvalidDataException();
                    return null;
                }
                else
                {
                    B = record;
                }
            }
            return B;
        }
    }
}
