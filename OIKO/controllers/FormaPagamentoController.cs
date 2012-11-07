using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oiko.controllers
{
    public class FormaPagamentoController
    {
        public static void addFormaPagamento(string nome)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    FormaPagamento formaPagamento = new FormaPagamento { nome = nome };
                    db.FormaPagamento.InsertOnSubmit(formaPagamento);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar criar a formaPagamento", ex);
            }
        }
        public static FormaPagamento getFormaPagamento(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    FormaPagamento formaPagamento = db.FormaPagamento.SingleOrDefault(fp => fp.id == id);
                    if (formaPagamento == null)
                    {
                        throw new Exception(
                            string.Format("A formaPagamento com id {0} não foi encontrada", id)
                            );
                    }
                    return formaPagamento;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar retornar a formaPagamento", ex);
            }
        }
        public static void updateFormaPagamento(int id, string nome)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    FormaPagamento formaPagamento = db.FormaPagamento.SingleOrDefault(fp => fp.id == id);
                    if (formaPagamento == null)
                    {
                        throw new Exception(
                            string.Format("A formaPagamento com id {0} não foi encontrada", id)
                            );
                    }
                    formaPagamento.nome = nome;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar a formaPagamento", ex);
            }
        }
        public static void deleteFormaPagamento(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    FormaPagamento formaPagamento = db.FormaPagamento.SingleOrDefault(fp => fp.id == id);
                    if (formaPagamento == null)
                    {
                        throw new Exception(
                            string.Format("A formaPagamento com id {0} não foi encontrada", id)
                            );
                    }
                    db.FormaPagamento.DeleteOnSubmit(formaPagamento);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a formaPagamento", ex);
            }
        }

        public static List<FormaPagamento> All()
        {
            using (OikoDataContext db = new OikoDataContext())
            {
                return db.FormaPagamento.OrderBy(fp => fp.id).ToList();
            }
        }
    }
}
