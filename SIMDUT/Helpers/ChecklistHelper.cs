using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using SIMDUT.Models;

namespace SIMDUT.Helpers
{

    public class ChecklistItemHelper
    {
        public static ObservableCollection<Grouping<string, ChecklistItem>> ChecklistItemGrouped { get; set; }

        public static ObservableCollection<ChecklistItem> ChecklistItem { get; set; }

        static ChecklistItemHelper()
        {
            ChecklistItem = new ObservableCollection<ChecklistItem>();



            #region SIMDUT
            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Le produit dangereux est accompagné d'une étiquette du fournisseur.",
                Section = "",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Je sais où trouver la fiche signalétique de ce produit.",
                Section = "",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Je reconnais et comprends les symboles de danger sur l'étquette.",
                Section = "",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Je connais les précautions à prendre lorsque je travaille avec ce produit.",
                Section = "",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Si le produit est placé dans un nouveau contenant ou si l'étiquette dufournisseur est illisible, le contenant doit porter une étiquette du lieu de travail.",
                Section = "",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Je connais les procédures de sécurité si une situation d'urgence implique le produit dangereux.",
                Section = "",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Fourni les étiquettes du SIMDUT et FDS appropriées.",
                Section = "Le fournisseur a :",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Élaboré des procédures de travail sécuritaires pour les employés.",
                Section = "L'employeur a :",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Fourni aux employés une formation régulière du SIMDUT.",
                Section = "L'employeur a :",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Veillé à ce que les FDS soient exactes et disponibles.",
                Section = "L'employeur a :",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Fourni des étiquettes du lieu de travail, au besoin.",
                Section = "L'employeur a :",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Profité de la formation régulière du SIMDUT.",
                Section = "L'employé a :",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Mis en pratique les apprentissages retenus de sa formation.",
                Section = "L'employé a :",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Avisé l'employeur ou le fournisseur des étiquettes ou les FDS sont périmées, inexactes ou absentes.",
                Section = "L'employé a :",
                
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Utilisé l’équipement de protection approprié lorsqu’il travaille avec chaque produit dangereux.",
                Section = "L'employé a :",
                
                IsChecked = false
            });
            #endregion




            var sorted = from s in ChecklistItem
                         orderby s.ID
                         group s by s.Section into sGroup
                         select new Grouping<string, ChecklistItem>(sGroup.Key, sGroup);


            ChecklistItemGrouped = new ObservableCollection<Grouping<string, ChecklistItem>>(sorted);
        }
    }
}
