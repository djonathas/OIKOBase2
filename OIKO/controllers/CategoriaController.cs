using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oiko.controllers
{
    public class CategoriaController
    {
        public static void addCategoria(string nome, string tipo)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Categoria categoria = new Categoria { nome = nome, tipo = tipo };
                    db.Categoria.InsertOnSubmit(categoria);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar criar a categoria", ex);
            }
        }
        public static Categoria getCategoria(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Categoria categoria = db.Categoria.SingleOrDefault(c => c.id == id);
                    if (categoria == null)
                    {
                        throw new Exception(
                            string.Format("A categoria com id {0} não foi encontrada", id)
                            );
                    }
                    return categoria;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar retornar a categoria", ex);
            }
        }
        public static void updateCategoria(int id, string nome, string tipo)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Categoria categoria = db.Categoria.SingleOrDefault(c => c.id == id);
                    if (categoria == null)
                    {
                        throw new Exception(
                            string.Format("A categoria com id {0} não foi encontrada", id)
                            );
                    }
                    categoria.nome = nome;
                    categoria.tipo = tipo;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar a categoria", ex);
            }
        }
        public static void deleteCategoria(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Categoria categoria = db.Categoria.SingleOrDefault(c => c.id == id);
                    if (categoria == null)
                    {
                        throw new Exception(
                            string.Format("A categoria com id {0} não foi encontrada", id)
                            );
                    }
                    db.Categoria.DeleteOnSubmit(categoria);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a categoria", ex);
            }
        }

        public static List<Categoria> All()
        {
            using (OikoDataContext db = new OikoDataContext())
            {
                return db.Categoria.OrderBy(c => c.id).ToList();
            }
        }
    }
}
