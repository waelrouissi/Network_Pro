using ProfessionalNetwork.Domaine.Entities;
using ProfessionalNetwork.Models;
using ProfessionalNetwork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfessionalNetwork.Controllers
{
    public class PostsController : Controller

    {
        public ApplicationService _IApplicationService { get; set; }

        public JobOfferService _IJobOfferService { get; set; }

        public JobSeekerService _IJobSeekerService { get; set; }

        public EntrepriseAdminService _IEntrepriseService { get; set; }

        public InterviewService _IInterviewService { get; set; }

        public PostService _IPostsService { get; set; }
        public LikesService _ILikesService { get; set; }

        public PostsController()
        {
            _IApplicationService = new ApplicationService();
            _IJobOfferService = new JobOfferService();
            _IJobSeekerService = new JobSeekerService();
            _IEntrepriseService = new EntrepriseAdminService();
            _IInterviewService = new InterviewService();
            _IPostsService = new PostService();
            _ILikesService = new LikesService();
        }
        // GET: Posts
        public ActionResult Index()
        {

            var l = _IPostsService.GetAll();
            var like = _ILikesService.GetAll();

            List<PostsVM> p = new List<PostsVM>();

            foreach (var item in l)
            {
                var _JobSeeker = _IJobSeekerService.GetById(item.Job_SeekerFK);

                PostsVM PVM = new PostsVM
                {
                    Id_Post = item.Id_Post,
                    Post = item.Post,
                    Date_Post = item.Date_Post,
                    Job_SeekerFK = item.Job_SeekerFK,
                    isLiked = false,
                    isPostOwner = false,
                    nbrLikes = 0,

                    Jobseeker = new JobseekerVM
                    {
                        id_jobseeker = _JobSeeker.id_jobseeker,
                        Intro_jobseeker = _JobSeeker.Intro_jobseeker,
                        Username = _JobSeeker.Username,
                        Last_Name = _JobSeeker.Last_Name,
                        First_Name = _JobSeeker.First_Name,
                        Photo = _JobSeeker.Photo,
                        Date_of_birth = _JobSeeker.Date_of_birth,
                        Date_Created = _JobSeeker.Date_Created,
                        Date_Modified = _JobSeeker.Date_Modified,
                        Date_Deleted = _JobSeeker.Date_Deleted,
                        Certif = _JobSeeker.Certif,
                        Email = _JobSeeker.Email,
                        Enable = _JobSeeker.Enable,
                        Pwd = _JobSeeker.Pwd,
                        IsDeleted = _JobSeeker.IsDeleted,
                        Skills = _JobSeeker.Skills,
                    }



                };
                foreach (var i in like)
                {
                    if (i.FK_Post == item.Id_Post)
                    {
                        PVM.nbrLikes = PVM.nbrLikes + 1;
                    }

                    if ((i.FK_Post == item.Id_Post) && (i.FK_jobseeker == 1))
                    {
                        PVM.isLiked = true;
                    }


                }

                if (PVM.Job_SeekerFK == 1)
                {
                    PVM.isPostOwner = true;
                }
                p.Add(PVM);



            }
            return View(p);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        public ActionResult Create(PostsVM PVM)
        {


            _IPostsService.Add(new Posts
            {
                Post = PVM.Post,
                Date_Post = DateTime.Now,
                Job_SeekerFK = PVM.Job_SeekerFK
            });
            _IPostsService.Commit();
            return View();

        }


        public ActionResult LikePost(int id)
        {
            _ILikesService.Add(new Likes
            {

                FK_jobseeker = 1,
                FK_Post = id


            }
            );
            _ILikesService.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult ViewComments(int id)
        {

            return RedirectToAction("Index", "Comments", new { id });
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Posts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            // Posts Post = _IPostsService.GetById(id);
            _IPostsService.Delete(_IPostsService.GetById(id));
            _IPostsService.Commit();

            return RedirectToAction("Index");
        }

        // POST: Posts/Delete/5
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Delete(int id, PostsVM PVMn)
        {
            //Posts Post = _IPostsService.GetById(id);
            //if (Post == null)
            //    return View("Not found");
            //_IPostsService.Delete(Post);
            //_IPostsService.Update(Post);
            return View();

        }
    }
}
