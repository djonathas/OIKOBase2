using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oiko.controllers
{
    public class UsuarioController
    {
        public static void add(Usuario usuario)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    db.Usuario.InsertOnSubmit(usuario);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar criar o usuario", ex);
            }
        }
        public static Usuario get()
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Usuario usuario = db.Usuario.First();
                    if (usuario == null)
                    {
                        throw new Exception(
                            string.Format("Não existe usuário cadastrado!")
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
        public static void updateUsuario(Usuario usuarioAtualizado)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Usuario usuario = get();

                    usuario.nome = usuarioAtualizado.nome;
                    usuario.email = usuarioAtualizado.email;
                    usuario.login = usuarioAtualizado.login;
                    usuario.senha = usuarioAtualizado.senha;

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

        public static bool existeUsuario()
        {
            using (OikoDataContext db = new OikoDataContext())
            {
                if (db.Usuario.Count() > 0)
                    return true;
                return false;
            }
        }
    }
}
