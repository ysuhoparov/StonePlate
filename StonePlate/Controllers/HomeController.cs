using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StonePlate.Models;

namespace StonePlate.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        TileContext db = new TileContext();

        public ActionResult Index()
        {
            // получаем из бд координаты плит
    //        IEnumerable<Slab> Slabs = db.Slabs;
            // передаем все объекты в динамические свойства в ViewBag
     //       ViewBag.Slabs = Slabs;

            IEnumerable<Tile> Tiles = db.Tiles;
            ViewBag.Tiles = Tiles;
            
            IEnumerable<Dimension> Dimensions = db.Dimensions;
            ViewBag.Dimensions = Dimensions;

            IEnumerable<Graph> Graphs = db.Graphs;
            ViewBag.Graphs = Graphs;

            int Width = 400;
            ViewBag.Width = Width;
            int Height = 410;
            ViewBag.Height = Height;

            int xRect = 46;
            ViewBag.xRect = xRect;
            int yRect = 20;
            ViewBag.yRect = yRect;

            int WidthRect = 206;
            ViewBag.WidthRect = WidthRect;
            ViewBag.RRect = WidthRect+ xRect;
            int HeightRect = 265;
            ViewBag.HeightRect = HeightRect;
            ViewBag.BottRect = HeightRect+ yRect;


            int xtl = Tiles.Last().xLen/10;
            int[] xTiles = new int[1+WidthRect/xtl]; ;
           
            for (int i = 0;  i < xTiles.Length; i++) {
                xTiles[i] = xRect+i*xtl;
            }
            ViewBag.xTiles = xTiles;

            int ytl = Tiles.Last().yLen/10;
            int[] yTiles = new int[1+ HeightRect / ytl]; ;

            for (int i = 0; i < yTiles.Length; i++)
            {
                yTiles[i] = yRect + i * ytl;
            }
            ViewBag.yTiles = yTiles;




            // возвращаем представление

            return View();
        }
    }
}