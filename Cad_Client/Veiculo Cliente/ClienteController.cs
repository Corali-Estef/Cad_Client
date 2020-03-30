using cadastro.veiculos;
using System;
using System.Web;
using System.Web.Mvc;

namespace cadastro.veiculos
{
    public class ClienteVeiculos : Veiculos
    {
        private DBContext db = new DBContext();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ClienteVeiculos));

        #region Actions

        // Cliente
        public ActionResult Index()
        {
            ViewBag.Title = "Clientes";
            return View();
        }


        public ActionResult Listar(string nome)
        {
            var lista = new List<Cliente>();

            try
            {
                if (string.IsNullOrEmpty(nome))
                    lista = db.Clientes.ToList();
                else
                    lista = db.Clientes.Where(m => m.Nome.Contains(nome)).ToList();
            }
            catch (Exception ex)
            {
                //TODO: LOG   
                log.Error(ex.Message);
            }

            return PartialView(" ", lista);
        }
