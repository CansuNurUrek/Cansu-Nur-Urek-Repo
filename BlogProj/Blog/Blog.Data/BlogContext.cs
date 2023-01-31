using Blog.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class BlogContext: DbContext 
    {
        public BlogContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostCategories> PostCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PostCategories>()
                .HasKey(pc => new
                {
                    pc.PostId,
                    pc.CategoryId

                });

            modelBuilder
              .Entity<Category>()
              .HasData(
              new Category() { Id = 1, Name = "Topics", ImageUrl = "1.webp", Url = "topics" },
              new Category() { Id = 2, Name = "Platforms and Communities",  ImageUrl = "2.webp", Url = "platforms_and_communities" },
              new Category() { Id = 3, Name = "Companies", ImageUrl = "3.webp", Url = "companies" },
              new Category() { Id = 4, Name = "Inspires", ImageUrl = "4.webp", Url = "inpires" }
          
              );
            modelBuilder
                .Entity<Post>()
                .HasData(
                new Post() { Id=1, Name= "Code Better", Url = "code_better", ImgUrl = "1.jpg", Description= "The CodeBetter blog has one main goal — introduce developers to better tools, methodologies, and practices within software development. It’s focused on technical content that is actually relevant rather than filling their blog with random fluff to increase views. What makes CodeBetter different from other blogs is that they avoid writing about stuff that does not work and spend time criticizing it. They focus on pointing out what is good and worth your time. The blog can definitely be trusted in terms of information as the writers post purely based on their personal experiences and knowledge. You will find plenty of code examples and innovative techniques here. It is perfect for developers who are focused on Microsoft technologies, especially .Net based languages, SQL Server, Sharepoint, BizTalk, server platforms and other software. Follow @Codebetter on Twitter." },
                new Post() { Id = 2, Name = "A List Apart", Url = "a_list_apart", ImgUrl = "2.jpg", Description = "Another successful blog for software developers: A List Apart started out as a mailing list back in 1997. The website has been up and running since 1998! It was founded by L. Jeffrey Zeldman and features contributing writers like Senongo Akpem, Rachel Andrew, Cennydd Bowles, Anthony Colangelo, Lyza Danger Gardner, Debra Gelman, Matt Griffin, and many more. This is a perfect destination for those who are looking for a place to broaden their knowledge of software development or just wandering around for some cool tips and tricks. The blog covers all kinds of topics on the design, development, and meaning of web content, but more specifically on web standards and best practices. A List Apart welcomes other writers, developers, strategists, designers and other specialists to post on their blog as long as they have some interesting thoughts to share with the world of developers. Follow @alistapart on Twitter." },
                new Post() { Id = 3, Name = "The Steelkiwi Blog", Url = "the_steelkiwi_blog", ImgUrl = "3.jpg", Description = "Back in 2011, Viacheslav Ponomarov and Anton Baterikov, working in engineering and management positions within the IT outsourcing industry, joined forces to start Steelkiwi, a full-cycle software development company. Apart from providing comprehensive IT services, they also regularly contribute content about design, development, software support, and even compliance regulations to the Steelkiwi Blog. A trusted source of information for both startups and seasoned entrepreneurs, the company’s blog aims to bring complex terms and processes from the IT industry closer to businesses pursuing to develop custom apps and websites. Follow @SteelKiwiDev on Twitter." },
                new Post() { Id = 4, Name = "Coding Horror", Url = "coding_horror", ImgUrl = "4.jpg", Description = "Jeff Atwood began the Coding Horror blog in 2004 and ever since he has been keeping his readers entertained with his brilliant posts full of humor. Throughout the years, Jeff took the readers on his journey of growth as a writer and software developer. Currently, his posts are easy to read and understand — something you would enjoy reading after a hard day at work. A rather rare thing in software development… Jeff is also a co-founder of Stack Exchange Network of Q&A sites, formerly Stack Overflow, which he created together with Joel Spolsky. Follow @codinghorror on Twitter." },

                new Post() { Id = 5, Name = "Microsoft", Url = "microsoft", ImgUrl = "5.jpg", Description = "As perhaps the world’s most significant architect of information technology, multinational tech titan Microsoft continues to drive how we work, learn, play, and do business in the digital world. From its humble beginnings in 1975 to its current status as a household name, the company has shaped the software industry as we know it. It boasts more than 180,000 employees in its offices in dozens of countries around the world, and posted $168 billion in revenue in 2021.There has been no shortage of records broken and distinctions earned by Microsoft and its remarkable team over its five - decade history.Over the last several years,the company has passed numerous milestones,such as its $1 trillion market cap in 2019 and $600 billion global brand value.Some of the most recent achievements by the Redmond - based innovator are its acquisitions of game company Activision Blizzard and speech recognition software maker Nuance Communications.Microsoft also continues to support digital education with its ongoing work to bring cutting - edge tech like Windows 11 SE to K–8 schools across the world." },
                new Post() { Id = 6, Name = "Adobe", Url = "adobe", ImgUrl = "5.jpg", Description = "As one of the top software providers in the world, tech giant Adobe serves millions of users across the globe. Since its start in 1982, the company has primarily been known for its multimedia and creativity software offerings. Its popular products include Photoshop, Acrobat Reader, and Creative Cloud.As of 2022, Adobe has more than 26, 000 employees worldwide,about 40 % of whom work in San Jose,California,where the company maintains its headquarters.On top of that, Adobe has field offices in about 30 countries across the Americas, Asia and Europe.It also has major development operations in India.A long - time publisher of traditional software packages, Adobe was instrumental in the creation of the desktop publishing industry.Since then,the company has found tremendous success by adapting to shifts in the market, leading the charge into the cloud and subscription - based business model.Propelled by these digital offerings, its revenue more than doubled between 2015 and 2019.More recently,Adobe achieved record quarterly revenue of $4.39 billion in the second quarter of its fiscal year 2022." },
                new Post() { Id = 7, Name = "Twilio", Url = "twilio", ImgUrl = "6.jpg", Description = "Today’s leading companies trust Twilio’s customer engagement platform to drive real-time, personalized experiences with their customers. Communication channels like voice, text, chat, video, and email are virtualized through APIs that are simple enough for any developer to use, yet robust enough to power the world’s most demanding applications. This ability to greatly enhance communication earned the company early support from the likes of Airbnb, Home Depot, Uber, and Walmart. Launched in 2008 by Jeff Lawson, Evan Cooke, and John Wolthuis, the San Francisco-based company now boasts more than 5,000 employees in 26 offices in 17 countries and counting.In June 2016,after years of increased private funding, Twilio went public and started trading with a 92% increase on the first day.Since then, it has carried this momentum into 2022 and delivered another strong quarter to start the year, with first quarter revenue coming in at $875 million, representing 48% year-over-year growth.As of March 31, 2022, the platform has 268,000 active customer accounts, compared to 235,000 on March 31, 2021." },
                new Post() { Id = 8, Name = "Nutanix", Url = "nutanix", ImgUrl = "7.jpg", Description = "Nutanix is one of the world’s great cloud computing companies, and is recognized as one of the best in the field when it comes to cloud services and software-defined storage. Founded 13 years ago by Dheeraj Pandey, Mohit Aron, and Ajeet Singh, Nutanix has empowered clients to optimize the efficiency of their systems. It has met with striking success in this mission, pivoting last year from hardware to subscription software and earning $1.4 billion in revenue in the process.Led by new President and Chief Executive Officer Rajiv Ramaswami,Nutanix employs a team of more than 6,000 software experts(or “Nutants,” as they are affectionately known within the company).It has repeatedly been hailed as one of the best tech workplaces in the world by Fortune and The Washington Post and was recently named a Gartner Peer Insights Customers’ Choice for hyperconverged infrastructure software and distributed files and object storage.Notable acquisitions in recent years have included Netsil, Minjar, and MainFrame2, enhancing the company’s cloud monitoring and application delivering capabilities." },

                new Post() { Id = 9, Name = "Stack Overflow", Url = "stack_overflow", ImgUrl = "8.jpg", Description = "" },
                new Post() { Id = 10, Name = "Chrome Developer Tools", Url = "chrome_developer_tools", ImgUrl = "8.jpg", Description = "Wouldn’t it be great if you could edit your HTML and CSS in real-time, or debug your JavaScript, all while viewing a thorough performance analysis of your website?Google’s built -in Chrome Developer Tools let you do just that. Bundled and available in both Chrome and Safari, they allow developers access into the internals of their web application. On top of this, a palette of network tools can help optimize your loading flows, while a timeline gives you a deeper understanding of what the browser is doing at any given moment.Google release an update every six weeks–so check out their website as well as the Google Developers YouTube channel to keep your skills up - to - date." },
                new Post() { Id = 11, Name = "GitHub", Url = "github", ImgUrl = "9.jpg", Description = "It’s every developer’s worst nightmare—you’re working on a new project feature and you screw up. Enter version control systems (VCS)–and more specifically, GitHub.By rolling out your project with the service, you can view any changes you’ve made or even go back to your previous state (making pesky mistakes a thing of the past). There are so many reasons why GitHub is vital to developers. The repository hosting service also boasts a rich open-source development community (making collaboration between teams as easy as pie), as well as providing several other components such as bug tracking, feature requests, task management, and wikis for every project.Many employers will look for finely-honed Git skills, so now’s the perfect time to sign up–plus it’s a great way to get involved and learn from the best with a wide array of open-source projects to work on. If you’re not 100% sure of the differences between Git and GitHub already, make sure you know that first." },
                new Post() { Id = 12, Name = "jQuery", Url = "jquery", ImgUrl = "10.jpg", Description = "JavaScript has long been considered an essential frontend language by developers, although it’s not without its problems: riddled with browser inconsistencies, its somewhat complicated and unapproachable syntax meant that functionality often suffered.That was until 2006 when jQuery—a fast, small, cross - platform JavaScript library aimed at simplifying the frontend process—appeared on the scene.By abstracting a lot of the functionality usually left for developers to solve on their own, jQuery allowed greater scope for creating animations, adding plug - ins, or even just navigating documents.And it’s clearly successful—jQuery was by far the most popular JavaScript library in existence in 2015, with installation on 65 % of the top 10 million highest - traffic sites on the web at the time.If this sounds like something you’d like to look into some more, we have a full guide to jQuery vs JavaScript." },

                new Post() { Id = 13, Name = "Dennis Ritchie", Url = "dennis_ritchie", ImgUrl = "11.jpg", Description = "Dennis MacAlistair Ritchie was a computer scientist from the United States who “helped shape the digital era.” He co-created the C programming language and the Unix operating system with long-time colleague Ken Thompson. Ritchie and Thompson received the ACM Turing Award in 1983, the IEEE Hamming Medal in 1990, and President Clinton’s National Medal of Technology in 1999. Ritchie retired in 2007 as the head of the Lucent Technologies System Software Research Department." },
                new Post() { Id = 14, Name = "Bjarne Stroustrup", Url = "bjarne_stroustrup", ImgUrl = "12.jpg", Description = "Bjarne Stroustrup is a Danish computer scientist best known for developing the widely used C++ programming language. He is a Distinguished Research Professor at Texas A&M University and holds the College of Engineering Chair in Computer Science. He is also a visiting professor at Columbia University and works for Morgan Stanley." },
                new Post() { Id = 15, Name = "James Gosling", Url = "james_gosling", ImgUrl = "13.jpg", Description = "James Arthur Gosling is a computer scientist from Canada who is best known as the creator of the Java programming language. He has also made significant contributions to several other software systems, including NeWS and Gosling Emacs. Gosling was elected as a Foreign Associate Member of the United States National Academy of Engineering to recognize his extraordinary achievements." }


                );

            modelBuilder
               .Entity<PostCategories>()
               .HasData(
               new PostCategories() { PostId = 1, CategoryId = 1 },
               new PostCategories() { PostId = 2, CategoryId = 1 },
               new PostCategories() { PostId = 3, CategoryId = 1 },
               new PostCategories() { PostId = 4, CategoryId = 1 },

               new PostCategories() { PostId = 5, CategoryId = 3 },
               new PostCategories() { PostId = 6, CategoryId = 3 },
               new PostCategories() { PostId = 7, CategoryId = 3 },
               new PostCategories() { PostId = 8, CategoryId = 3 },

               new PostCategories() { PostId = 9, CategoryId = 2 },
               new PostCategories() { PostId = 10, CategoryId = 2 },
               new PostCategories() { PostId = 11, CategoryId = 2 },
               new PostCategories() { PostId = 12, CategoryId = 2 },

               new PostCategories() { PostId = 13, CategoryId = 4 },
               new PostCategories() { PostId = 14, CategoryId = 4 },
               new PostCategories() { PostId = 15, CategoryId = 4 }

               );
        }

        }
}
