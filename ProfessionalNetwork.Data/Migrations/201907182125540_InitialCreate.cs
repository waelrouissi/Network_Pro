namespace ProfessionalNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Application",
                c => new
                    {
                        Id_Application = c.Long(nullable: false, identity: true),
                        Date_Application = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        State = c.Int(nullable: false),
                        Job_OfferFK = c.Long(nullable: false),
                        Job_SeekerFK = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Application)
                .ForeignKey("dbo.Job_Offer", t => t.Job_OfferFK, cascadeDelete: true)
                .ForeignKey("dbo.Job_Seeker", t => t.Job_SeekerFK, cascadeDelete: true)
                .Index(t => t.Job_OfferFK)
                .Index(t => t.Job_SeekerFK);
            
            CreateTable(
                "dbo.Interview",
                c => new
                    {
                        Id_Interview = c.Long(nullable: false),
                        Date_Interview = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Type_Interview = c.Int(nullable: false),
                        State_interview = c.Int(nullable: false),
                        TestFK = c.Long(nullable: false),
                        Applciation_FK = c.Long(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_Interview)
                .ForeignKey("dbo.Application", t => t.Applciation_FK, cascadeDelete: true)
                .ForeignKey("dbo.Test", t => t.Id_Interview)
                .Index(t => t.Id_Interview)
                .Index(t => t.Applciation_FK);
            
            CreateTable(
                "dbo.Test",
                c => new
                    {
                        Id_Test = c.Long(nullable: false, identity: true),
                        Nbr_Question = c.Int(nullable: false),
                        Nbr_Point_Tolal = c.Int(nullable: false),
                        Name_Test = c.String(),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_Test);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id_Question = c.Long(nullable: false, identity: true),
                        Content_Question = c.String(),
                        Correct_AnswerID = c.Int(nullable: false),
                        Point_Question = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        choice1 = c.String(),
                        choice2 = c.String(),
                        choice3 = c.String(),
                        TestFK = c.Long(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_Question)
                .ForeignKey("dbo.Test", t => t.TestFK, cascadeDelete: true)
                .Index(t => t.TestFK);
            
            CreateTable(
                "dbo.Job_Offer",
                c => new
                    {
                        Id_JobOffer = c.Long(nullable: false, identity: true),
                        job_title = c.String(),
                        Job_Description = c.String(),
                        Date_Offer = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Nbr_Candidat = c.Int(nullable: false),
                        Date_Expiration = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        visibility = c.Boolean(nullable: false),
                        EntrepirseFK = c.Long(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_JobOffer)
                .ForeignKey("dbo.Entreprise_admin", t => t.EntrepirseFK, cascadeDelete: true)
                .Index(t => t.EntrepirseFK);
            
            CreateTable(
                "dbo.Entreprise_admin",
                c => new
                    {
                        Id_Entrepirse = c.Long(nullable: false, identity: true),
                        Name_Entrerise = c.String(),
                        Intro_Entreprise = c.String(),
                        NB_Employee = c.Int(nullable: false),
                        Role = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Pwd = c.String(),
                        Enable = c.Boolean(nullable: false),
                        Photo = c.String(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id_Entrepirse);
            
            CreateTable(
                "dbo.Job_Seeker",
                c => new
                    {
                        id_jobseeker = c.Long(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Intro_jobseeker = c.String(),
                        Date_of_birth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Certif = c.String(),
                        Skills = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Pwd = c.String(),
                        Enable = c.Boolean(nullable: false),
                        Photo = c.String(nullable: false),
                        Date_Created = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Modified = c.DateTime(precision: 7, storeType: "datetime2"),
                        Date_Deleted = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsDeleted = c.Boolean(),
                        Entreprise_admin_Id_Entrepirse = c.Long(),
                    })
                .PrimaryKey(t => t.id_jobseeker)
                .ForeignKey("dbo.Entreprise_admin", t => t.Entreprise_admin_Id_Entrepirse)
                .Index(t => t.Entreprise_admin_Id_Entrepirse);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id_Com = c.Int(nullable: false, identity: true),
                        FK_jobseeker = c.Long(nullable: false),
                        FK_Post = c.Long(nullable: false),
                        Comment = c.String(),
                        Date_Com = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id_Com)
                .ForeignKey("dbo.Job_Seeker", t => t.FK_jobseeker)
                .ForeignKey("dbo.Posts", t => t.FK_Post)
                .Index(t => t.FK_jobseeker)
                .Index(t => t.FK_Post);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id_Post = c.Long(nullable: false, identity: true),
                        Post = c.String(),
                        Date_Post = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Job_SeekerFK = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Post)
                .ForeignKey("dbo.Job_Seeker", t => t.Job_SeekerFK)
                .Index(t => t.Job_SeekerFK);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id_Like = c.Long(nullable: false, identity: true),
                        FK_jobseeker = c.Long(nullable: false),
                        FK_Post = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Like)
                .ForeignKey("dbo.Job_Seeker", t => t.FK_jobseeker, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.FK_Post)
                .Index(t => t.FK_jobseeker)
                .Index(t => t.FK_Post);
            
            CreateTable(
                "dbo.Project_Manager",
                c => new
                    {
                        Id_Project_Manager = c.Long(nullable: false, identity: true),
                        Role = c.String(),
                        Id_Entreprise_admin = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Project_Manager)
                .ForeignKey("dbo.Entreprise_admin", t => t.Id_Entreprise_admin, cascadeDelete: true)
                .Index(t => t.Id_Entreprise_admin);
            
            CreateTable(
                "dbo.Follows",
                c => new
                    {
                        Id_Entrepirse = c.Long(nullable: false),
                        id_jobseeker = c.Long(nullable: false),
                        Date_Follow = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => new { t.Id_Entrepirse, t.id_jobseeker })
                .ForeignKey("dbo.Entreprise_admin", t => t.Id_Entrepirse, cascadeDelete: true)
                .ForeignKey("dbo.Job_Seeker", t => t.id_jobseeker, cascadeDelete: true)
                .Index(t => t.Id_Entrepirse)
                .Index(t => t.id_jobseeker);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Follows", "id_jobseeker", "dbo.Job_Seeker");
            DropForeignKey("dbo.Follows", "Id_Entrepirse", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Application", "Job_SeekerFK", "dbo.Job_Seeker");
            DropForeignKey("dbo.Application", "Job_OfferFK", "dbo.Job_Offer");
            DropForeignKey("dbo.Job_Offer", "EntrepirseFK", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Project_Manager", "Id_Entreprise_admin", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Job_Seeker", "Entreprise_admin_Id_Entrepirse", "dbo.Entreprise_admin");
            DropForeignKey("dbo.Comments", "FK_Post", "dbo.Posts");
            DropForeignKey("dbo.Likes", "FK_Post", "dbo.Posts");
            DropForeignKey("dbo.Likes", "FK_jobseeker", "dbo.Job_Seeker");
            DropForeignKey("dbo.Posts", "Job_SeekerFK", "dbo.Job_Seeker");
            DropForeignKey("dbo.Comments", "FK_jobseeker", "dbo.Job_Seeker");
            DropForeignKey("dbo.Interview", "Id_Interview", "dbo.Test");
            DropForeignKey("dbo.Question", "TestFK", "dbo.Test");
            DropForeignKey("dbo.Interview", "Applciation_FK", "dbo.Application");
            DropIndex("dbo.Follows", new[] { "id_jobseeker" });
            DropIndex("dbo.Follows", new[] { "Id_Entrepirse" });
            DropIndex("dbo.Project_Manager", new[] { "Id_Entreprise_admin" });
            DropIndex("dbo.Likes", new[] { "FK_Post" });
            DropIndex("dbo.Likes", new[] { "FK_jobseeker" });
            DropIndex("dbo.Posts", new[] { "Job_SeekerFK" });
            DropIndex("dbo.Comments", new[] { "FK_Post" });
            DropIndex("dbo.Comments", new[] { "FK_jobseeker" });
            DropIndex("dbo.Job_Seeker", new[] { "Entreprise_admin_Id_Entrepirse" });
            DropIndex("dbo.Job_Offer", new[] { "EntrepirseFK" });
            DropIndex("dbo.Question", new[] { "TestFK" });
            DropIndex("dbo.Interview", new[] { "Applciation_FK" });
            DropIndex("dbo.Interview", new[] { "Id_Interview" });
            DropIndex("dbo.Application", new[] { "Job_SeekerFK" });
            DropIndex("dbo.Application", new[] { "Job_OfferFK" });
            DropTable("dbo.Follows");
            DropTable("dbo.Project_Manager");
            DropTable("dbo.Likes");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Job_Seeker");
            DropTable("dbo.Entreprise_admin");
            DropTable("dbo.Job_Offer");
            DropTable("dbo.Question");
            DropTable("dbo.Test");
            DropTable("dbo.Interview");
            DropTable("dbo.Application");
        }
    }
}
