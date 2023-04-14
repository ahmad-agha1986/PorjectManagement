using Microsoft.EntityFrameworkCore;


namespace WebApplication2.Models
{
    public class MyDatabaseContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "App_Data", "MyDatabase.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");


          


        }
        public DbSet<Task1> Tasks { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Project1> Projects { get; set; }
        public DbSet<UserRecord> UserRecords { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<UserAuth> UserAuths { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

       

            // relational keys Project & client 
            modelBuilder.Entity<Project1>()
                .HasOne(p => p.Client)
                .WithMany(c => c.Project)
                .HasForeignKey(p => p.Client_Id)
                .OnDelete(DeleteBehavior.SetNull);

            //relational keys User & UserAuth
            modelBuilder.Entity<User>()
            .HasOne(usr => usr.UserAuth)
            .WithMany(ua => ua.User)
            .HasForeignKey(usr => usr.UserAuth_Id)
            .OnDelete(DeleteBehavior.Cascade);



            //  relational keys Task &  Project 
            modelBuilder.Entity<Task1>()
                .HasOne(t => t.Project)
                .WithMany(p => p.Task)
                .HasForeignKey(t => t.Project_Id)
                .OnDelete(DeleteBehavior.SetNull);


            //relational keys Task & user
            modelBuilder.Entity<Task1>()
                .HasOne(t => t.User)
                .WithMany(u => u.Task)
                .HasForeignKey(t => t.User_Id)
                .OnDelete(DeleteBehavior.SetNull);



            //relational keys Notification & User
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany(ur => ur.Notification)
                .HasForeignKey(n => n.User_Id)
                .OnDelete(DeleteBehavior.SetNull);


            //relational keys UserRecord & Task
            modelBuilder.Entity<UserRecord>()
                .HasOne(s => s.Task)
                .WithMany(ur => ur.UserRecords)
                .HasForeignKey(s => s.Task_Id)
                .OnDelete(DeleteBehavior.SetNull);


            //relational keys UserRecord & User
            modelBuilder.Entity<UserRecord>()
              .HasOne(u => u.User)
              .WithMany(ur => ur.UserRecords)
              .HasForeignKey(u => u.User_Id)
              .OnDelete(DeleteBehavior.SetNull);

            //relational keys for Authantication tables


            modelBuilder.Entity<UserRoles>()
                .HasOne(uR => uR.UserAuth)
                .WithMany(uu => uu.UserRole)
                .HasForeignKey(uR => uR.UserAuthId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<UserRoles>()
                .HasOne(uRr => uRr.Role)
                .WithMany(rr => rr.UserRoles)
                .HasForeignKey(uRr => uRr.RoleId)
                .OnDelete(DeleteBehavior.Cascade);








            //seeding data for Client

            //modelBuilder.Entity<Client>().HasData(
            //new Client { Client_Id = 1, FirstName = "Ashley ", LastName = "Martinez", Email = "Ashley.Martinez@financeteam.net", Phone = "0412 345 678", Address = "7 Carnarvon Crescent", City = "Stanhope Garden", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 2, FirstName = "John", LastName = "Williams", Email = "John.Williams@moneyplus.com", Phone = "0432 123 456", Address = "24 Teakwood Drive", City = "Narre Warren South", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 3, FirstName = "Jessica", LastName = "Smith", Email = "Jessica.Smith@finance.com", Phone = "0421 987 654", Address = "29 Rofe Street", City = "Leichhardt", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 4, FirstName = "Tyler", LastName = "Davis", Email = "Tyler.Johnson@investoradvisor.net", Phone = "0456 789 012", Address = "14 Elsom Street", City = "South Windsor", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 5, FirstName = "Samantha", LastName = "Brown", Email = "Samantha.Davis@finance.com", Phone = "0401 234 567", Address = "5 View Road", City = "Springwood", State = "QLD", Country = "Australia" },
            //new Client { Client_Id = 6, FirstName = "David", LastName = "Rodriguez", Email = "David.Brown@moneywise.com.au", Phone = "0437 456 789", Address = "5 Norman Street", City = " Doncaster", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 7, FirstName = "Maria", LastName = "Anderson", Email = "Maria.Rodriguez@finance.com", Phone = "0423 210 987", Address = "16 Rydges Street", City = "South Wentworthville", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 8, FirstName = "Kevin", LastName = "Wilson", Email = "Kevin.Anderson@finance.com", Phone = "0445 678 901", Address = "4 Bluebell Circuit", City = "Coffs Harbour", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 9, FirstName = "Olivia", LastName = "Miller", Email = "Olivia.Wilson@finance.com", Phone = "0409 876 543", Address = "21 Willow Crescent", City = " Footscray", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 10, FirstName = "Michael", LastName = "Taylor", Email = "Michael.Miller@@financialadvice.net", Phone = "0434 321 098", Address = "25 Tiernan Street", City = "Mount Druitt", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 11, FirstName = "Sarah", LastName = "Thompson", Email = "Sarah.Taylor@finance.com", Phone = "0415 678 901", Address = "2/49 Acacia Street", City = "Mandurah", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 12, FirstName = "Christopher", LastName = "Jackson", Email = "Christopher.Thompson@finance.com", Phone = "0426 543 210", Address = "1/23 Hollis Street", City = " Bonbeach", State = "WA", Country = "Australia" },
            //new Client { Client_Id = 13, FirstName = "Joshua", LastName = "Lewis", Email = "Emily.Jackson@moneycoach.com", Phone = "0450 987 654", Address = "15 Giselle Avenue", City = "Mosman", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 14, FirstName = "Elizabeth", LastName = "Clark", Email = "Joshua.Lewis@finance.com", Phone = "0407 321 098", Address = "2/6 Belmont Road", City = "Buddina", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 15, FirstName = "Daniel", LastName = "Lee", Email = "Elizabeth.Clark@finance.com", Phone = "0439 876 543", Address = "34 Orana Parade", City = "Penrith", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 16, FirstName = "Taylor", LastName = "Hall", Email = "Daniel.Lee@@financetoday.net", Phone = "0418 765 432", Address = "9 Carey Street", City = " Bossley Park", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 17, FirstName = "Matthew", LastName = "Wright", Email = "Taylor.Hall@finance.com", Phone = "0429 012 345", Address = "42 Mimosa Road", City = "Smithfield", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 18, FirstName = "Madison", LastName = "Scott", Email = "Matthew.Wright@finance.com", Phone = "0441 234 567", Address = "27 Pirrama Road", City = "Ocean Grove", State = "QLD", Country = "Australia" },
            //new Client { Client_Id = 19, FirstName = "Andrew", LastName = "Perez", Email = "Madison.Scott@finance.com", Phone = "0405 876 543", Address = "14 Long Street", City = "Pakenham", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 20, FirstName = "Alyssa", LastName = "Cooper", Email = "Andrew.Perez@yourfinancials.com", Phone = "0430 210 987", Address = "3/25 Lake Avenue", City = "Laverton", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 21, FirstName = "Robert", LastName = "Baker", Email = "Alyssa.Cooper@finance.com", Phone = "0413 456 789", Address = "1/12 Station Street", City = "Rothwell", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 22, FirstName = "Lauren", LastName = "Turner", Email = "Robert.Baker@moneymentor.net", Phone = "0424 321 098", Address = "13 Neville Avenue", City = "Carlton", State = "QLD", Country = "Australia" },
            //new Client { Client_Id = 23, FirstName = "William", LastName = "Gonzalez", Email = "Lauren.Turner@finance.com", Phone = "0453 654 321", Address = "16 Vaucluse Place", City = "Coorparoo", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 24, FirstName = "Rachel", LastName = "Adams", Email = "William.Gonzalez@financialadvice.net", Phone = "0408 765 432", Address = "4/1 Hampton Court Road", City = "Thornleigh", State = "QLD", Country = "Australia" },
            //new Client { Client_Id = 25, FirstName = "James ", LastName = "Wright", Email = "Rachel.Adams@finance.com", Phone = "0436 012 345", Address = "1/2 Marday Street", City = "Padbury", State = "NSW", Country = "Australia" },
            //new Client { Client_Id = 26, FirstName = "Victoria", LastName = "Nelson", Email = "James.Wright@wealthbuilder.net", Phone = "0417 654 321", Address = "46 Holt Parade", City = "Geelong West", State = "WA", Country = "Australia" },
            //new Client { Client_Id = 27, FirstName = "Benjamin", LastName = "Johnson", Email = "Victoria.Nelson@yourwealth.com", Phone = "0428 901 234", Address = "23 Howard Road", City = "Burleigh Waters", State = "VIC", Country = "Australia" },
            //new Client { Client_Id = 28, FirstName = "Grace", LastName = "Flores", Email = "Benjamin.Flores@moneyplan.net", Phone = "0440 543 210", Address = "9 Panorama Avenue", City = "Anytown", State = "QLD", Country = "Australia" },
            //new Client { Client_Id = 29, FirstName = "Jane", LastName = "Mitchell", Email = "Grace.Mitchell@finance.com", Phone = "0406 789 012", Address = "10 Dolly Avenue", City = "Clontarf", State = "QLD", Country = "Australia" },
            //new Client { Client_Id = 30, FirstName = "Nicholas", LastName = "Collins", Email = "Nicholas.Collins@finance.com", Phone = "0431 234 567", Address = "8 O'Grady Street", City = "Coorparoo", State = "QLD", Country = "Australia" }
            //);




            ////// //// seeding data for Project

            //modelBuilder.Entity<Project>().HasData(
            //new Project { Project_Id = 50, Name = "Financial Analysis Report", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 1 },
            //new Project { Project_Id = 51, Name = " Business Plan Development", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 2 },
            //new Project { Project_Id = 52, Name = " Tax Compliance Audit", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 4 },
            //new Project { Project_Id = 53, Name = "Risk Assessment Strategy", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 4 },
            //new Project { Project_Id = 54, Name = "Budget Planning and Analysis", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 5 },
            //new Project { Project_Id = 55, Name = "Market Research and Analysis", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 6 },
            //new Project { Project_Id = 56, Name = "Investment Portfolio Management", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 7 },
            //new Project { Project_Id = 57, Name = "Accounting System Implementation", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 8 },
            //new Project { Project_Id = 58, Name = "Cost Optimization Initiative", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 8 },
            //new Project { Project_Id = 59, Name = "Corporate Social Responsibility ", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 10 },
            //new Project { Project_Id = 60, Name = "Financial Analysis Report", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 10 },
            //new Project { Project_Id = 61, Name = "Market Research and Analysis", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 12 },
            //new Project { Project_Id = 62, Name = " Accounting System Implementation", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 15 },
            //new Project { Project_Id = 63, Name = "Business Plan Development", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 14 },
            //new Project { Project_Id = 64, Name = "Corporate Social Responsibility Program", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 15 },
            //new Project { Project_Id = 65, Name = "Cost Optimization Initiative", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 16 },
            //new Project { Project_Id = 66, Name = "Tax Compliance Audit", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 17 },
            //new Project { Project_Id = 67, Name = "Risk Assessment Strategy", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 18 },
            //new Project { Project_Id = 68, Name = "Market Research and Analysis", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 19 },
            //new Project { Project_Id = 69, Name = "Investment Portfolio Management", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 20 },
            //new Project { Project_Id = 70, Name = "Financial Analysis Report", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 20 },
            //new Project { Project_Id = 71, Name = " Corporate Social Responsibility Program", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 20 },
            //new Project { Project_Id = 72, Name = "Accounting System Implementation", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 23 },
            //new Project { Project_Id = 73, Name = "Business Plan Development", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 24 },
            //new Project { Project_Id = 74, Name = "Risk Assessment Strategy", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 25 },
            //new Project { Project_Id = 75, Name = "Market Research and Analysis", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 26 },
            //new Project { Project_Id = 76, Name = "Cost Optimization Initiative", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 22 },
            //new Project { Project_Id = 77, Name = "Financial Analysis Report", DueDate = new DateTime(2022, 12, 31), Status = "On going", Client_Id = 28 },
            //new Project { Project_Id = 78, Name = " Corporate Social Responsibility Program", DueDate = new DateTime(2023, 3, 15), Status = "On going", Client_Id = 29 },
            //new Project { Project_Id = 79, Name = "Risk Assessment Strategy", DueDate = new DateTime(2023, 6, 30), Status = "On going", Client_Id = 28 }
            //);


            //// seeding data for User

            //modelBuilder.Entity<User>().HasData(
            //new User { User_Id = 100, Job_Title = "Resource Manager ",          FirstName = "John",         LastName = "Doe",       Password = "Password123",   Email = "johndoe@admin.com",                Phone = "0422 123 456", Role = "Admin", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 101, Job_Title = "Financial Analyst ",         FirstName = "Alice",        LastName = "Smith",     Password = "Summer2023",    Email = "alicesmith@financeteam.com",       Phone = "0413 456 789", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 102, Job_Title = "Investment Banker ",         FirstName = "Daniel ",      LastName = "Johnson",   Password = "Pineapple21",   Email = "danieljohnson@financeteam.com",    Phone = "0438 987 654", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 103, Job_Title = "Risk Manager ",              FirstName = "Eva",          LastName = "Ortiz",     Password = "BlueBird20",    Email = "evaortiz@financeteam.com",         Phone = "0488 765 432", Role = "User", Registration_date = DateTime.Now, OnLeave = true },
            //new User { User_Id = 104, Job_Title = "Accountant ",                FirstName = "Mike",         LastName = "Wang",      Password = "LovelyDay22",   Email = "mikewang@financeteam.com",         Phone = "0400 555 666", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 105, Job_Title = "Financial Planner ",         FirstName = "Chris",        LastName = "Brown",     Password = "Happy2023!",    Email = "chrisbrown@financeteam.com",       Phone = "0456 888 777", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 106, Job_Title = "Credit Analyst ",            FirstName = "Sara",         LastName = "Foster",    Password = "Secret123",     Email = "sarafoster@financeteam.com",       Phone = "0499 222 111", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 107, Job_Title = "Treasury Analyst ",          FirstName = "Matt",         LastName = "Davis",     Password = "CoolCat21",     Email = "mattdavis@financeteam.com",        Phone = "0424 333 222", Role = "User", Registration_date = DateTime.Now, OnLeave = true },
            //new User { User_Id = 108, Job_Title = "Asset Manager ",             FirstName = "Lucy",         LastName = "Chen",      Password = "GoldenSun22",   Email = "lucychen@financeteam.com",         Phone = "0432 111 333", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 109, Job_Title = "Compliance Officer ",        FirstName = "Tom",          LastName = "Coleman",   Password = "StarrySky20",   Email = "tomcoleman@financeteam.com",       Phone = "0444 888 222", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 110, Job_Title = "Actuary ",                   FirstName = "Amy",          LastName = "Kim",       Password = "RedRose2023",   Email = "amykim@financeteam.com",           Phone = "0465 222 333", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 111, Job_Title = "Tax Advisor ",               FirstName = "John",         LastName = "Powell",    Password = "Mountain21",    Email = "johnpowell@financeteam.com",       Phone = "0477 333 111", Role = "User", Registration_date = DateTime.Now, OnLeave = true },
            //new User { User_Id = 112, Job_Title = "Auditor  ",                  FirstName = "Jessica",      LastName = "Howard",    Password = "CrazyBird22",   Email = "jessicahoward@financeteam.com",    Phone = "0405 444 555", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 113, Job_Title = "Controller ",                FirstName = "Gabriel",      LastName = "Holland",   Password = "OceanView23",   Email = "gabrielholland@financeteam.com",   Phone = "0411 666 555", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 114, Job_Title = "Portfolio Manager ",         FirstName = "Davis",        LastName = "Cox",       Password = "BrightSun20",   Email = "daviscox@financeteam.com",         Phone = "0455 777 444", Role = "User", Registration_date = DateTime.Now, OnLeave = true },
            //new User { User_Id = 115, Job_Title = "Wealth Manager  ",           FirstName = "Ashley",       LastName = "Simpson",   Password = "Dancing21!",    Email = "ashleysimpson@financeteam.com",    Phone = "0423 888 333", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 116, Job_Title = "Insurance Underwriter",      FirstName = "Christophe",   LastName = "Brown",     Password = "Peaceful22",    Email = "chris.brown@financeteam.com",      Phone = "0409 555 777", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 117, Job_Title = "Budget Analyst  ",           FirstName = "Sara",         LastName = "Lee",       Password = "SunnyDay23",    Email = "sara.lee@financeteam.com",         Phone = "0467 777 444", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 118, Job_Title = "Corporate Finance Manager",  FirstName = "Lily",         LastName = "Larson",    Password = "Joyful21",      Email = "lily.larson@financeteam.com",      Phone = "0498 444 888", Role = "User", Registration_date = DateTime.Now, OnLeave = true },
            //new User { User_Id = 119, Job_Title = "Financial Consultant ",      FirstName = "Isaac ",       LastName = "Chen",      Password = "SilverMoon20",  Email = "isaac.chen@financeteam.com",       Phone = "0426 555 666", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 120, Job_Title = "Loan Officer ",              FirstName = "Elijah",       LastName = "Rivera",    Password = "LuckyDay22",    Email = "elijah.rivera@financeteam.com",    Phone = "0435 666 888", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 121, Job_Title = "Financial Advisor ",         FirstName = "Julian",       LastName = "Kim",       Password = "PurpleRain23",  Email = "julian.kim@financeteam.com",       Phone = "0472 333 555", Role = "User", Registration_date = DateTime.Now, OnLeave = true },
            //new User { User_Id = 122, Job_Title = "Data Analyst ",              FirstName = "John",         LastName = "Murphy",    Password = "WildFlower21",  Email = "john.murphy@financeteam.com",      Phone = "0431 777 666", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 123, Job_Title = "Procurement Specialist ",    FirstName = "Adrian ",      LastName = "Webb",      Password = "HappyHour20!",  Email = "adrian.webb@financeteam.com",      Phone = "0480 888 777", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 124, Job_Title = " Financial Advisor",         FirstName = "Bob",          LastName = "Sanders",   Password = "Morning22",     Email = "bob.sanders@financeteam.com",      Phone = "0407 555 222", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 125, Job_Title = " Supply Chain Manager",      FirstName = "Eva",          LastName = "Ross",      Password = "OceanBreeze23", Email = "eva.ross@financeteam.com",         Phone = "0461 777 888", Role = "User", Registration_date = DateTime.Now, OnLeave = true },
            //new User { User_Id = 126, Job_Title = " Investment Banker",         FirstName = "Mike",         LastName = "Wang",      Password = "Chocolate21",   Email = "mike.wang@financeteam.comm",       Phone = "0434 555 777", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 127, Job_Title = "Management Consultant ",     FirstName = "Chris",        LastName = "Brown",     Password = "GreenTree22",   Email = "chris.brown@financeteam.com",      Phone = "0429 666 111", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 128, Job_Title = " Sales Manager",             FirstName = "Sara",         LastName = "Sanchez",   Password = "SnowyDay20",    Email = "sara.sanchez@financeteam.com",     Phone = "0452 888 666", Role = "User", Registration_date = DateTime.Now, OnLeave = false },
            //new User { User_Id = 129, Job_Title = "Business Developer",         FirstName = "Mia ",         LastName = "Bryant",    Password = "Diamond2023",   Email = "mia.bryant@financeteam.com",       Phone = "0479 555 444", Role = "User", Registration_date = DateTime.Now, OnLeave = true }

            // );







            //seeding data for Task

            //modelBuilder.Entity<Task1>().HasData(
            //new Task1 { Task_Id = 150, Name = "Conducting Financial Analysis ", TimeEstimate = 4.0, StartDate = new DateTime(01 / 01 / 2023), EndDate = new DateTime(01 / 02 / 2023),                                                               Status = "InProgress",         Project_Id = 50,       User_Id = 102 },
            //new Task1 { Task_Id = 151, Name = "Developing Business Plan ", TimeEstimate = 4.0, StartDate = new DateTime(01 / 03 / 2023), EndDate = new DateTime(01 / 04 / 2023),                                                                    Status = "Unassigned",         Project_Id = 50,       User_Id = null },
            //new Task1 { Task_Id = 152, Name = "Conducting Tax Compliance Audit", TimeEstimate = 4.0, StartDate = new DateTime(01 / 05 / 2023), EndDate = new DateTime(01 / 07 / 2023),                                                              Status = "Complete",           Project_Id = 55,       User_Id = 102 },
            //new Task1 { Task_Id = 153, Name = "Developing Risk Assessment Strategy ", TimeEstimate = 4.0, StartDate = new DateTime(01 / 08 / 2023), EndDate = new DateTime(01 / 10 / 2023),                                                         Status = "InProgress",         Project_Id = 55,       User_Id = 106 },
            //new Task1 { Task_Id = 154, Name = "Conducting Budget Planning", TimeEstimate = 4.0, StartDate = new DateTime(01 / 11 / 2023), EndDate = new DateTime(01 / 12 / 2023),                                                                   Status = "InProgress",         Project_Id = 51,       User_Id = 115 },
            //new Task1 { Task_Id = 155, Name = "Conducting Market Research ", TimeEstimate = 4.0, StartDate = new DateTime(01 / 13 / 2023), EndDate = new DateTime(01 / 14 / 2023),                                                                  Status = "Unassigned",         Project_Id = 52,       User_Id = null },
            //new Task1 { Task_Id = 156, Name = "Managing Investment Portfolio", TimeEstimate = 4.0, StartDate = new DateTime(01 / 15 / 2023), EndDate = new DateTime(01 / 17 / 2023),                                                                Status = "Unassigned",         Project_Id = 53,       User_Id = null },
            //new Task1 { Task_Id = 157, Name = "Implementing Accounting System ", TimeEstimate = 4.0, StartDate = new DateTime(01 / 18 / 2023), EndDate = new DateTime(01 / 20 / 2023),                                                              Status = "Unassigned",         Project_Id = 60,       User_Id = null },
            //new Task1 { Task_Id = 158, Name = "Optimizing Costs", TimeEstimate = 4.0, StartDate = new DateTime(01 / 21 / 2023), EndDate = new DateTime(01 / 23 / 2023),                                                                             Status = "Complete",           Project_Id = 60,       User_Id = 125 },
            //new Task1 { Task_Id = 159, Name = "Developing Corporate Social Responsibility Program", TimeEstimate = 4.0, StartDate = new DateTime(01 / 24 / 2023), EndDate = new DateTime(01 / 25 / 2023),                                           Status = "Complete",           Project_Id = 61,       User_Id = 119 },
            //new Task1 { Task_Id = 160, Name = "Performing Financial Statement Analysis ", TimeEstimate = 4.0, StartDate = new DateTime(01 / 26 / 2023), EndDate = new DateTime(01 / 28 / 2023),                                                     Status = "InProgress",         Project_Id = 56,       User_Id = 122 },
            //new Task1 { Task_Id = 161, Name = "Conducting Competitive Analysis", TimeEstimate = 4.0, StartDate = new DateTime(01 / 29 / 2023), EndDate = new DateTime(01 / 31 / 2023),                                                              Status = "Unassigned",         Project_Id = 65,       User_Id = null },
            //new Task1 { Task_Id = 162, Name = "Managing Accounts Payable", TimeEstimate = 4.0, StartDate = new DateTime(02 / 01 / 2023), EndDate = new DateTime(02 / 03 / 2023),                                                                    Status = "InProgress",         Project_Id = 65,       User_Id = 112 },
            //new Task1 { Task_Id = 163, Name = "Conducting Sales Forecasting ", TimeEstimate = 4.0, StartDate = new DateTime(02 / 04 / 2023), EndDate = new DateTime(02 / 06 / 2023),                                                                Status = "Unassigned",         Project_Id = 70,       User_Id = null },
            //new Task1 { Task_Id = 164, Name = "Developing Performance Metrics", TimeEstimate = 4.0, StartDate = new DateTime(02 / 07 / 2023), EndDate = new DateTime(02 / 08 / 2023),                                                               Status = "InProgress",         Project_Id = 77,       User_Id = 122 },
            //new Task1 { Task_Id = 165, Name = "Developing Cost Reduction Strategies", TimeEstimate = 4.0, StartDate = new DateTime(02 / 09 / 2023), EndDate = new DateTime(02 / 11 / 2023),                                                         Status = "InProgress",         Project_Id = 77,       User_Id = 122 },
            //new Task1 { Task_Id = 166, Name = "Conducting Compliance Audits ", TimeEstimate = 4.0, StartDate = new DateTime(02 / 12 / 2023), EndDate = new DateTime(02 / 13 / 2023),                                                                Status = "Complete",           Project_Id = 79,       User_Id = 123 },
            //new Task1 { Task_Id = 167, Name = "Creating Strategic Plans ", TimeEstimate = 4.0, StartDate = new DateTime(02 / 14 / 2023), EndDate = new DateTime(02 / 16 / 2023),                                                                    Status = "Unassigned",         Project_Id = 78,       User_Id = null },
            //new Task1 { Task_Id = 168, Name = "Conducting Industry Analysis", TimeEstimate = 4.0, StartDate = new DateTime(02 / 17 / 2023), EndDate = new DateTime(02 / 19 / 2023),                                                                 Status = "Complete ",          Project_Id = 79,       User_Id = 110 },
            //new Task1 { Task_Id = 169, Name = "Conducting Investment Analysis", TimeEstimate = 4.0, StartDate = new DateTime(02 / 20 / 2023), EndDate = new DateTime(02 / 22 / 2023),                                                               Status = "InProgress",         Project_Id = 74,       User_Id = 101 },
            //new Task1 { Task_Id = 170, Name = "Conducting Financial Due Diligence", TimeEstimate = 4.0, StartDate = new DateTime(02 / 23 / 2023), EndDate = new DateTime(02 / 24 / 2023),                                                           Status = " InProgress",        Project_Id = 75,       User_Id = 101 },
            //new Task1 { Task_Id = 171, Name = "Conducting Environmental Impact Assessment ", TimeEstimate = 4.0, StartDate = new DateTime(02 / 25 / 2023), EndDate = new DateTime(02 / 27 / 2023),                                                  Status = "InProgress",         Project_Id = 70,       User_Id = 101 },
            //new Task1 { Task_Id = 172, Name = "Implementing Internal Controls", TimeEstimate = 4.0, StartDate = new DateTime(02 / 28 / 2023), EndDate = new DateTime(03 / 01 / 2023),                                                               Status = "Unassigned ",        Project_Id = 69,       User_Id = null },
            //new Task1 { Task_Id = 173, Name = "Developing Growth Strategies", TimeEstimate = 4.0, StartDate = new DateTime(03 / 02 / 2023), EndDate = new DateTime(03 / 04 / 2023),                                                                 Status = "Unassigned",         Project_Id = 69,       User_Id = null },
            //new Task1 { Task_Id = 174, Name = "Conducting Risk Assessments", TimeEstimate = 4.0, StartDate = new DateTime(03 / 05 / 2023), EndDate = new DateTime(03 / 06 / 2023),                                                                  Status = " Unassigned",        Project_Id = 50,       User_Id = null },
            //new Task1 { Task_Id = 175, Name = "Developing Marketing Plans", TimeEstimate = 4.0, StartDate = new DateTime(03 / 07 / 2023), EndDate = new DateTime(03 / 09 / 2023),                                                                   Status = "Complete",           Project_Id = 52,       User_Id = 122 },
            //new Task1 { Task_Id = 176, Name = "Conducting Vendor Analysis ", TimeEstimate = 4.0, StartDate = new DateTime(03 / 10 / 2023), EndDate = new DateTime(03 / 12 / 2023),                                                                  Status = "InProgress",         Project_Id = 54,       User_Id = 121 },
            //new Task1 { Task_Id = 177, Name = "Conducting Financial Modeling ", TimeEstimate = 4.0, StartDate = new DateTime(03 / 13 / 2023), EndDate = new DateTime(03 / 14 / 2023),                                                               Status = "Complete",           Project_Id = 54,       User_Id = 126 },
            //new Task1 { Task_Id = 178, Name = "Conducting Employee Training Programs", TimeEstimate = 4.0, StartDate = new DateTime(03 / 15 / 2023), EndDate = new DateTime(03 / 17 / 2023),                                                        Status = "Unassigned",         Project_Id = 77,       User_Id = null }

            //);










            // seeding data for UserRecord
            //modelBuilder.Entity<UserRecord>().HasData(
            //new UserRecord { UserRecord_Id = 200, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 150 },
            //new UserRecord { UserRecord_Id = 201, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 152 },
            //new UserRecord { UserRecord_Id = 202, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 153 },
            //new UserRecord { UserRecord_Id = 203, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 153 },
            //new UserRecord { UserRecord_Id = 204, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 155 },
            //new UserRecord { UserRecord_Id = 205, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 156 },
            //new UserRecord { UserRecord_Id = 206, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 160 },
            //new UserRecord { UserRecord_Id = 207, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 161 },
            //new UserRecord { UserRecord_Id = 208, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 162 },
            //new UserRecord { UserRecord_Id = 209, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 162 },
            //new UserRecord { UserRecord_Id = 210, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 162 },
            //new UserRecord { UserRecord_Id = 211, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 165 },
            //new UserRecord { UserRecord_Id = 212, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 166 },
            //new UserRecord { UserRecord_Id = 213, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 168 },
            //new UserRecord { UserRecord_Id = 214, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 169 },
            //new UserRecord { UserRecord_Id = 215, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 169 },
            //new UserRecord { UserRecord_Id = 216, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 170 },
            //new UserRecord { UserRecord_Id = 217, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 171 },
            //new UserRecord { UserRecord_Id = 218, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 177 },
            //new UserRecord { UserRecord_Id = 219, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 178 },
            //new UserRecord { UserRecord_Id = 220, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 178 },
            //new UserRecord { UserRecord_Id = 221, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 174 },
            //new UserRecord { UserRecord_Id = 222, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 173 },
            //new UserRecord { UserRecord_Id = 223, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 151 },
            //new UserRecord { UserRecord_Id = 224, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 151 },
            //new UserRecord { UserRecord_Id = 225, Date = new DateTime(2022, 1, 1), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 154 },
            //new UserRecord { UserRecord_Id = 226, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(12, 0, 0), Task_Id = 153 },
            //new UserRecord { UserRecord_Id = 227, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 158 },
            //new UserRecord { UserRecord_Id = 228, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 159 },
            //new UserRecord { UserRecord_Id = 229, Date = new DateTime(2022, 1, 2), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(16, 0, 0), Task_Id = 160 }

            //);



            // // seeding data for Notification
            //modelBuilder.Entity<Notification>().HasData(
            //new Notification { Notification_Id = 250, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 150 },
            //new Notification { Notification_Id = 251, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 150 },
            //new Notification { Notification_Id = 252, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 150 },
            //new Notification { Notification_Id = 253, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 151 },
            //new Notification { Notification_Id = 254, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 151 },
            //new Notification { Notification_Id = 255, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 151 },
            //new Notification { Notification_Id = 256, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 152 },
            //new Notification { Notification_Id = 257, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 168 },
            //new Notification { Notification_Id = 258, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 166 },
            //new Notification { Notification_Id = 259, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 166 },
            //new Notification { Notification_Id = 230, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 162 },
            //new Notification { Notification_Id = 231, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 163 },
            //new Notification { Notification_Id = 232, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 170 },
            //new Notification { Notification_Id = 233, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 178 },
            //new Notification { Notification_Id = 234, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 178 },
            //new Notification { Notification_Id = 235, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 176 },
            //new Notification { Notification_Id = 236, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 177 },
            //new Notification { Notification_Id = 237, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 153 },
            //new Notification { Notification_Id = 238, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 153 },
            //new Notification { Notification_Id = 239, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 156 },
            //new Notification { Notification_Id = 240, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 154 },
            //new Notification { Notification_Id = 241, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 168 },
            //new Notification { Notification_Id = 242, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 163 },
            //new Notification { Notification_Id = 243, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 162 },
            //new Notification { Notification_Id = 244, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 161 },
            //new Notification { Notification_Id = 245, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 155 },
            //new Notification { Notification_Id = 246, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 155 },
            //new Notification { Notification_Id = 247, Type = "Task", Message = "Task has been created", Created_at = DateTime.Now, Task_Id = 157 },
            //new Notification { Notification_Id = 248, Type = "Task", Message = "Task has been updated", Created_at = DateTime.Now, Task_Id = 157 },
            //new Notification { Notification_Id = 249, Type = "Task", Message = "Task has been completed", Created_at = DateTime.Now, Task_Id = 150 }
            //);


        }

    }


}