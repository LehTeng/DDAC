using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DDAClehteng.Models;

namespace DDAClehteng.Controllers
{
    public class ShipViewController : Controller
    {
        // GET: ViewStatus
        public ActionResult Index()
        {
            List<ShipView> ShipView = new List<ShipView>();

            using (CMS_modelContainer context = new CMS_modelContainer())
            {
                ShipView = context.ShipViews.ToList();
            }

            return View(ShipView);
        }

        public ActionResult Add_New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add_New(ShipView svs)
        {

            using (CMS_modelContainer context = new CMS_modelContainer())
            {
                var shipView = new ShipView();
                
                shipView.Ship_Place = svs.Ship_Place;
                shipView.Ship_Depart= svs.Ship_Depart;
                shipView.Ship_Arrived = svs.Ship_Arrived;
                shipView.Status = "Pending";
                
                context.ShipViews.Add(shipView);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult EditStatus(int id)
        {
            var shipView = new ShipView();

            EditShipViewModel esvm = new EditShipViewModel();

            using (CMS_modelContainer context = new CMS_modelContainer())
            {
                shipView = context.ShipViews.Where(b => b.Ship_Id == id).FirstOrDefault();
                esvm.Ship_Id = shipView.Ship_Id;
                esvm.Ship_Place = shipView.Ship_Place;
                esvm.Ship_Depart = shipView.Ship_Depart;
                esvm.Ship_Arrived = shipView.Ship_Arrived;
                esvm.Status = shipView.Status;

            }
            esvm.listItem = new List<SelectListItem>();
            loadList(esvm.listItem);
            return View(esvm);
        }

        private void loadList(List<SelectListItem> list)
        {
            SelectListItem sli = new SelectListItem();
            sli.Text = "Pending";
            sli.Value = "Pending";
            list.Add(sli);

            sli = new SelectListItem();
            sli.Text = "In-Progress";
            sli.Value = "In-Progress";
            list.Add(sli);

            sli = new SelectListItem();
            sli.Text = "Arrived";
            sli.Value = "Arrived";
            list.Add(sli);
        }

        [HttpPost]
        public ActionResult EditStatus(EditShipViewModel b)
        {
            using(CMS_modelContainer context = new CMS_modelContainer())
            {
                var shipView = context.ShipViews.Single(e => e.Ship_Id == b.Ship_Id);

                shipView.Ship_Id = b.Ship_Id;
                shipView.Ship_Place = b.Ship_Place;
                shipView.Ship_Depart = b.Ship_Depart;
                shipView.Ship_Arrived = b.Ship_Arrived;
                shipView.Status = b.Status;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        public ActionResult DeleteStatus(int id)
        {
            var ShipView = new ShipView();
            using (CMS_modelContainer context = new CMS_modelContainer())
            {
                ShipView = context.ShipViews.Where(b => b.Ship_Id == id).FirstOrDefault();
                context.ShipViews.Remove(ShipView);
                context.SaveChanges();
            }

                return RedirectToAction("Index");
        }

    }
}