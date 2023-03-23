using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialManagerLibrary.Data.Models;
using FinancialManagerLibrary.Data.Repositories;
using FinancialManagerLibrary.Data.Interfaces;
using FinancialManager.Utilities;
using FinancialManagerLibrary.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinancialManager.UI.Controllers
{
    public class IncomeController : IController
    {
        IRepository<Income> incomeRepository;
    
        public IncomeController()
        {
            incomeRepository = new IncomeRepository();
        }

       
        //public void Add(Income entity)
        //{
        //    incomeRepository.Create(entity);
        //}

        //public void Delete(Income entity)
        //{
        //    incomeRepository.Delete(entity);
        //}

        //public void Update(Income entity)
        //{
        //    incomeRepository.Update(entity);
        //}
        //public IEnumerable<Income> GetAll(long userId)
        //{
        //    return incomeRepository.GetAllEntities(userId);
        //}

        //public Income Exists(Income entity)
        //{
        //    return incomeRepository.GetByEntity(entity);
        //}

        //public T Exists<T>(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        public IEntity Add(IEntity entity)
        {
            return incomeRepository.Create(ConvertEntity(entity));
        }

        public void Delete(IEntity entity)
        {
            incomeRepository.Delete(ConvertEntity(entity));
        }

        public void Update(IEntity entity)
        {
            incomeRepository.Update(ConvertEntity(entity));
        }

        IEnumerable<IEntity> IController.GetAll(long userId)
        {
            return incomeRepository.GetAllEntities(userId);
        }

        public IEntity Exists(IEntity entity)
        {
            return incomeRepository.GetByEntity(ConvertEntity(entity));
        }

        public IEntity GetById(int id)
        {
            return incomeRepository.GetById(id);
        }

        private Income ConvertEntity(IEntity entity)
        {
            return (Income)Convert.ChangeType(entity, typeof(Income));
        }



        //public void Add<T>(Income entity)
        //{
        //    incomeRepository.Create(entity);
        //}

        //public void Delete<T>(T entity)
        //{
        //    incomeRepository.Delete(income);
        //}

        //public void Update<T>(T entity)
        //{
        //    incomeRepository.Update(income);
        //}

        //public T Exists<T>(T entity)
        //{
        //    return incomeRepository.GetByEntity(income);
        //}


        #region original
        //IRepository<IEntity> incomeRepository;
        ////public event PropertyChangedEventHandler PropertyChanged;

        ////string _name = "";

        ////public string Name
        ////{
        ////    get { return _name; }
        ////    set
        ////    {
        ////        _name = value;
        ////        if (Name == _name)
        ////        {
        ////            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
        ////        }
        ////    }
        ////}
        ////public string? Address { get; set; }
        ////public string? Address2 { get; set; }
        ////public string? Frequency { get; set; }
        //public IEnumerable<Income>? GetIncome 
        //{ 
        //    get { return incomeRepository.GetAllEntities(ActiveUser.id); }
        //}
        //public Income Exists(Income income)
        //{
        //    return incomeRepository.GetByEntity(income);
        //}
        //public RadioButton? GetSelectedRadioButton(GroupBox gbx)
        //{
        //    return gbx.Controls.OfType<RadioButton>()
        //                   .FirstOrDefault(n => n.Checked);
        //}
        //public DataGridViewCell GetSelectedRowCell(DataGridView dgv, int cellIndex)
        //{
        //    return dgv.SelectedRows[0].Cells[cellIndex];
        //}
        ///// <summary>
        ///// This method requires the DataGridView to have multi-select Off
        ///// </summary>
        ///// <param name="dgv"></param>
        ///// <returns></returns>
        //public DataGridViewRow GetSelectedRow(DataGridView dgv)
        //{
        //    if (dgv.SelectedRows.Count > 0)
        //        return dgv.SelectedRows[0];
        //    else
        //        return null;
        //}

        //public void UnSelectAllRadioButtons(GroupBox gbx)
        //{
        //    foreach (Control ctrl in gbx.Controls)
        //    {
        //        if (ctrl is RadioButton)
        //            ((RadioButton)ctrl).Checked = false;
        //    }
        //}
        //public void SelectRadioButton(GroupBox gbx, string buttonText)
        //{
        //    foreach (Control ctrl in gbx.Controls)
        //    {
        //        if (ctrl is RadioButton)
        //        {
        //            if (buttonText == ((RadioButton)ctrl).Text)
        //            {
        //                ((RadioButton)ctrl).Checked = true;
        //            }
        //        }
        //    }
        //}

        //public void Add(Income income)
        //{
        //    incomeRepository.Create(income);
        //}
        //public void Update(Income income)
        //{
        //    incomeRepository.Update(income);
        //}
        //public void Delete(Income income)
        //{
        //    incomeRepository.Delete(income);
        //}

        //public IncomeController() 
        //{
        //    incomeRepository = new IncomeRepository<Income>();
        //}
        #endregion


    }
}
