 using Nutricion.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    public class Repository
    {
        private readonly string _path;

        public string StatusMessage { get; set; }

        private SQLiteConnection conn;

        private void Init()
        {
            if(conn is not null)
            {
                return;
            }
            else
            {
                conn = new(_path);
            }
            conn.CreateTable<IMC>();
        }

        public Repository(string path)
        {
            _path = path;
        }

        public void AgregarRegistro(IMC imc)
        {
            try
            {
                Init();
                if(imc == null)
                {
                    throw new Exception("Error al guardar");
                }
                else
                {
                    IMC imcGuardar = new IMC();
                    imcGuardar = imc;
                    imcGuardar.Fecha = DateTime.Now;

                    int resultado = conn.Insert(imcGuardar);
                    StatusMessage = "Registro guardado: " + resultado;
                }
            }
            catch (Exception ex)
            {
                StatusMessage = "Error al guardar";
            }
        }

        public List<IMC> ObtenerRegistros() 
        {
            try
            {
                Init();
                return conn.Table<IMC>().ToList();
            }
            catch (Exception ex) 
            {
                StatusMessage = "Error al otener datos" + ex.Message;
            }
            return new List<IMC>();
        }
    }
}
