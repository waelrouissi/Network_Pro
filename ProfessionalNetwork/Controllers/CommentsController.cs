using ProfessionalNetwork.Models;
using ProfessionalNetwork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfessionalNetwork.Controllers
{

    public class CommentsController : Controller
    {


        public JobSeekerService _IJobSeekerService { get; set; }

        public PostService _IPostsService { get; set; }
        public LikesService _ILikesService { get; set; }
        public CommentsService _ICommentsService { get; set; }
        public int idPost;

        public CommentsController()
        {

            this._IPostsService = new PostService();
            this._ILikesService = new LikesService();
            this._ICommentsService = new CommentsService();
            this._IJobSeekerService = new JobSeekerService();
            this.idPost = 0;
        }

        // GET: Comments/5
        public ActionResult Index(int id)
        {
            Session["idPost"] = id;
            var comments = _ICommentsService.GetAll();
            List<CommentsVM> list = new List<CommentsVM>();


            foreach (var item in comments)
            {
                if (item.FK_Post == id)
                {
                    var _JobSeeker = _IJobSeekerService.GetById(item.FK_jobseeker);
                    CommentsVM commentsVM = new CommentsVM
                    {
                        Comment = item.Comment,
                        Date_Com = item.Date_Com,
                        Jobseeker = new JobseekerVM
                        {
                            id_jobseeker = _JobSeeker.id_jobseeker,
                            First_Name = _JobSeeker.First_Name
                        }

                    };
                    list.Add(commentsVM);
                }

            }

            return View(list);
        }


        // GET: Comments/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comments/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMsg(String msg)
        {

            var id = ((int)Session["idPost"]);

            _ICommentsService.Add(new Domaine.Entities.Comments
            {
                Comment = msg,
                Date_Com = DateTime.Now,
                FK_jobseeker = 1,

                FK_Post = id

            }
            );

            _ICommentsService.Commit();
            return RedirectToAction("Index", new { id });

        }


        // POST: Comments/Create
        [HttpPost]
        public ActionResult Create(CommentsVM CVM)
        {


            _ICommentsService.Add(new Domaine.Entities.Comments
            {
                Comment = CVM.Comment,
                Date_Com = DateTime.Now,
                FK_jobseeker = 1,
                FK_Post = 1

            }
            );

            _ICommentsService.Commit();
            return RedirectToAction("Index", new { id = 1 });

        }

        // GET: Comments/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comments/Edit/5
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

        // GET: Comments/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Comments/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
