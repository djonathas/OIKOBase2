using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oiko.controllers
{
    public class ContaController
    {
        public static void addConta(string nome, decimal saldo, bool saldoNegativo)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Conta conta = new Conta { nome = nome, saldo = saldo, saldoNegativo = saldoNegativo};
                    db.Conta.InsertOnSubmit(conta);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar criar a conta", ex);
            }
        }
        public static Conta getConta(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Conta conta = db.Conta.SingleOrDefault(c => c.id == id);
                    if (conta == null)
                    {
                        throw new Exception(
                            string.Format("A conta com id {0} não foi encontrada", id)
                            );
                    }
                    return conta;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar retornar a conta", ex);
            }
        }
        public static void updateConta(int id, string nome, bool saldoNegativo)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Conta conta = db.Conta.SingleOrDefault(c => c.id == id);
                    if (conta == null)
                    {
                        throw new Exception(
                            string.Format("A conta com id {0} não foi encontrada", id)
                            );
                    }
                    conta.nome = nome;
                    conta.saldoNegativo = saldoNegativo;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar atualizar a conta", ex);
            }
        }
        public static void deleteConta(int id)
        {
            try
            {
                using (OikoDataContext db = new OikoDataContext())
                {
                    Conta conta = db.Conta.SingleOrDefault(c => c.id == id);
                    if (conta == null)
                    {
                        throw new Exception(
                            string.Format("A conta com id {0} não foi encontrada", id)
                            );
                    }
                    db.Conta.DeleteOnSubmit(conta);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir a conta", ex);
            }
        }

        public static List<Conta> All()
        {
            using (OikoDataContext db = new OikoDataContext())
            {
                return db.Conta.OrderBy(c => c.id).ToList();
            }
        }
    }
}
