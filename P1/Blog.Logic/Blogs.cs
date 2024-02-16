using System;
using System.Xml.Serialization;

namespace Blog.Logic
{
    public class Blogs
    {
        // Fields
        public int? blogId { get; set; }
        public DateTime? datePublished { get; set; }
        //Authors author;
        public string? authorName { get; set; }
        public string? blogTitle { get; set; }
        public string? theBlog { get; set; }
        private XmlSerializer Serializer = new XmlSerializer(typeof(Blogs));
        private static int idSeed = 1;

        // Constructors
        public Blogs(){}
        public Blogs(DateTime datePublished, string authorName, string blogTitle, string theBlog)
        {
            this.blogId = idSeed;
            idSeed++;
            this.datePublished = datePublished;
            //this.author = author;
            this.authorName = authorName;
            this.blogTitle = blogTitle;
            this.theBlog = theBlog;
        }

        public Blogs(DateTime? datePublished, string? authorName, string? blogTitle, string? theBlog)
        {
            this.blogId = idSeed;
            idSeed++;
            this.datePublished = datePublished;
            //this.author = author;
            this.authorName = authorName;
            this.blogTitle = blogTitle;
            this.theBlog = theBlog;            
        }

        // Methods
        public string SerializeXML()
        {
            var stringWriter = new StringWriter();
            Serializer.Serialize(stringWriter, this);
            stringWriter.Close();
            return stringWriter.ToString();
        }

        public string ToString()
        {
            var result = new System.Text.StringBuilder();
            result.AppendLine($"Journal Title: {this.blogTitle} \t Author: {this.authorName} \t Created: {this.datePublished}\n'{this.theBlog}'\n");
            return result.ToString();

            // it works, but it's a bad habit!
            // return $"Name: {this.name} \t Height: {this.height} in. \t Age: {this.age}";
        }
    }
}