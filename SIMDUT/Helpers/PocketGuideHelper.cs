using SIMDUT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SIMDUT.Helpers
{
    public class PocketGuideHelper
    {
        public static ObservableCollection<PocketGuideItem> Index { get; set; }

        static PocketGuideHelper()
        {
            Index = new ObservableCollection<PocketGuideItem>();


            #region SIMDUT
            Index.Add(new PocketGuideItem
            {
                Id = 1,
                Title = "Introduction",
                TargetType = typeof(SIMDUT.PocketGuide.PageIntroduction),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 2,
                Title = "SIMDUT Acronymes",
                TargetType = typeof(SIMDUT.PocketGuide.PageWhmisAcronym),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 3,
                Title = "Les trois principaux éléments du SIMDUT",
                TargetType = typeof(SIMDUT.PocketGuide.PageWhmisMainElements),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 4,
                Title = "Le SIMDUT est la loi!",
                TargetType = typeof(SIMDUT.PocketGuide.PageWhmisLaw),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 5,
                Title = "Responsabilités",
                TargetType = typeof(SIMDUT.PocketGuide.PageResponsibilities),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 6,
                Title = "Classe et catégorie",
                TargetType = typeof(SIMDUT.PocketGuide.PageClassAndCategory),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 7,
                Title = "Groupes de danger et pictogrammes",
                TargetType = typeof(SIMDUT.PocketGuide.PageHazardGroups),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 8,
                Title = "Pictogrammes",
                TargetType = typeof(SIMDUT.PocketGuide.PagePictograms),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 9,
                Title = "Vieux symboles du SIMDUT",
                TargetType = typeof(SIMDUT.PocketGuide.PageOldWhmis),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 10,
                Title = "Étiquettes",
                TargetType = typeof(SIMDUT.PocketGuide.PageLabels),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 11,
                Title = "Étiquettes du fournisseur",
                TargetType = typeof(SIMDUT.PocketGuide.PageSupplierLabels),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 12,
                Title = "Étiquettes du lieu de travail",
                TargetType = typeof(SIMDUT.PocketGuide.PageWorplaceLabels),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 13,
                Title = "Les fiches de données de sécurité (FDS)",
                TargetType = typeof(SIMDUT.PocketGuide.PageSDS),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 14,
                Title = "Secrets commerciaux",
                TargetType = typeof(SIMDUT.PocketGuide.PageTradeSecrets),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 15,
                Title = "Matières soustraites du SIMDUT",
                TargetType = typeof(SIMDUT.PocketGuide.PageExemptions),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 16,
                Title = "Produits destinés aux consommateurs",
                TargetType = typeof(SIMDUT.PocketGuide.PageConsumerProducts),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 17,
                Title = "Équipement de protection individuelle",
                TargetType = typeof(SIMDUT.PocketGuide.PagePPE),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 18,
                Title = "Formation SIMDUT",
                TargetType = typeof(SIMDUT.PocketGuide.PageWhmisTraining),

            });
            Index.Add(new PocketGuideItem
            {
                Id = 19,
                Title = "Manipulation sans danger",
                TargetType = typeof(SIMDUT.PocketGuide.PageSafeHandling),

            });

            #endregion

        }
    }
}
