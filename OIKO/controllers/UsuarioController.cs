using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oiko.controllers
{
    public class UsuarioController
    {
        public static void addUsuario(int id, string nome, string email, string login, string senha)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Usuario usuario = new Usuario { id = id, nome = nome, email = email, login = login, senha = senha };
                    db.Usuario.InsertOnSubmit(usuario);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar criar o usuario", ex);
            }
        }
        public static Usuario getUsuario(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Usuario usuario = db.Usuario.SingleOrDefault(u => u.id == id);
                    if (usuario == null)
                    {
                        throw new Exception(
                            string.Format("O usuario com id {0} não foi encontrada", id)
                            );
                    }
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar retornar a usuario", ex);
            }
        }
        public static void updateUsuario(int id, string nome, string email, string login, string senha)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Usuario usuario = db.Usuario.SingleOrDefault(u => u.id == id);
                    if (usuario == null)
                    {
                        throw new Exception(
                            string.Format("O usuario com id {0} não foi encontrada", id)
                            );
                    }
                    usuario.nome = nome;
                    usuario.email = email;
                    usuario.login = login;
                    usuario.senha = senha;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar a usuario", ex);
            }
        }
        public static void deleteUsuario(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Usuario usuario = db.Usuario.SingleOrDefault(u => u.id == id);
                    if (usuario == null)
                    {
                        throw new Exception(
                            string.Format("O usuario com id {0} não foi encontrada", id)
                            );
                    }
                    db.Usuario.DeleteOnSubmit(usuario);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a usuario", ex);
            }
        }

        public static List<Usuario> All()
        {
            using (OikoDataContext db = new OikoDataContext())
            {
                return db.Usuario.OrderBy(u => u.id).ToList();
            }
        }
    }
}
