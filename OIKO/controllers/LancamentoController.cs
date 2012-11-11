using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oiko.controllers
{
    public class LancamentoController
    {
        public static void add(Lancamento lancamento)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    db.Lancamento.InsertOnSubmit(lancamento);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar criar a lancamento", ex);
            }
        }
        public static Lancamento get(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Lancamento lancamento = db.Lancamento.SingleOrDefault(l => l.id == id);
                    if (lancamento == null)
                    {
                        throw new Exception(
                            string.Format("O lancamento com id {0} não foi encontrada", id)
                            );
                    }
                    return lancamento;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar retornar o lancamento", ex);
            }
        }
        public static void update(Lancamento nl)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Lancamento lancamento = db.Lancamento.SingleOrDefault(l => l.id == nl.id);
                    if (lancamento == null)
                    {
                        throw new Exception(
                            string.Format("O lancamento com id {0} não foi encontrado", nl.id)
                            );
                    }
                    lancamento.dataLancamento = nl.dataLancamento;
                    lancamento.valor = nl.valor;
                    lancamento.descricao = nl.descricao;
                    lancamento.idCategoria = nl.idCategoria;
                    lancamento.idConta = nl.idConta;
                    lancamento.idFormaPagamento = nl.idFormaPagamento;
                    lancamento.multa = nl.multa;
                    lancamento.jurosPorDia = nl.jurosPorDia;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar o lancamento", ex);
            }
        }

        public static void baixa(int id, DateTime dataRecebimentoPagamento, int idConta)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Lancamento lancamento = db.Lancamento.SingleOrDefault(l => l.id == id);
                    if (lancamento == null)
                    {
                        throw new Exception(
                            string.Format("O lancamento com id {0} não foi encontrado", id)
                            );
                    }
                    lancamento.dataRecebimentoPagamento = dataRecebimentoPagamento;
                    lancamento.idConta = idConta;
                    lancamento.status = true;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar o lancamento", ex);
            }
        }

        public static void delete(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Lancamento lancamento = db.Lancamento.SingleOrDefault(l => l.id == id);
                    if (lancamento == null)
                    {
                        throw new Exception(
                            string.Format("O lancamento com id {0} não foi encontrado", id)
                            );
                    }
                    db.Lancamento.DeleteOnSubmit(lancamento);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a lancamento", ex);
            }
        }

        public static List<Lancamento> all()
        {
            using (OikoDataContext db = new OikoDataContext())
            {
                return db.Lancamento.OrderBy(l => l.id).ToList();
            }
        }
    }
}
