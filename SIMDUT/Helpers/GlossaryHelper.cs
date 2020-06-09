using MvvmHelpers;
using SIMDUT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;


//https://github.com/jamesmontemagno/Xamarin.Forms-Monkeys

namespace SIMDUT.Helpers
{
    public static class GlossaryHelper
    {
        public static ObservableCollection<Grouping<string, GlossaryItem>> GlossaryGrouped { get; set; }

        public static ObservableCollection<GlossaryItem> Glossary { get; set; }

        static GlossaryHelper()
        {
            Glossary = new ObservableCollection<GlossaryItem>();
            //Replace("\n" with "&#x0a;")



            #region SIMDUT

            Glossary.Add(new GlossaryItem
            {
                Element = "Analyste",
                Definition = "Individu désigné à ce titre en application du paragraphe 21(1).",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Article manufacturé",
                Definition = "Article fabriqué selon une forme ou une conception qui lui confère une destination spécifique et dont l’usage, en des conditions normales, et l’installation, si celle - ci est nécessaire pour l’usage auquel il est destiné, n’entraînent pas le rejet de produits dangereux ni aucune forme de contact d’un individu avec ces produits.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Autoréactif",
                Definition = "Se dit d’un produit, d’un mélange ou d’une substance, liquide ou solide, thermiquement instable qui est susceptible de subir une décomposition fortement exothermique et dont la chaleur de décomposition est égale ou supérieure à 300 J / g, même en l’absence d’oxygène.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Brouillard",
                Definition = "Ensemble de gouttelettes de liquide en suspension dans l’air.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Catégorie de dangers",
                Definition = "Subdivision d'une classe de dangers qui indique la mesure dans laquelle le produit est dangereux(gravité du danger). La catégorie 1 représente toujours le niveau de danger le plus élevé(elle comprend les produits les plus dangereux de sa classe).Si la catégorie 1 est divisée, la catégorie 1A dans la même classe comprend des produits plus dangereux que ceux de la catégorie 1B.La catégorie 2 dans la même classe de dangers comprend des produits plus dangereux que ceux de la catégorie 3, etc.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "CL50",
                Definition = "Concentration d’un mélange ou d’une substance dans l’air qui provoque la mort de 50, 0 % d’un groupe d’animaux testés.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Classes de dangers",
                Definition = "Façon de regrouper les produits qui ont des propriétés semblables et présentent les mêmes dangers.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Conseil de prudence",
                Definition = "Phrase décrivant les mesures recommandées qu’il y a lieu de prendre pour réduire au minimum ou prévenir les effets nocifs découlant soit de l’exposition à un produit dangereux, soit du stockage ou de la manutention incorrects de ce produit.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Contenant",
                Definition = "Tout emballage ou récipient, à l’exclusion d’un réservoir de stockage, notamment un sac, un baril, une bouteille, une boîte, un tonneau, une cannette ou un cylindre.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Contenant externe",
                Definition = "Contenant externe du produit dangereux visible dans des conditions normales de manutention, sauf s’il constitue l’unique contenant de ce produit.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Corrosif pour la peau",
                Definition = "Se dit d’un mélange ou d’une substance susceptible de causer une corrosion cutanée.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Corrosion cutanée",
                Definition = "Apparition de lésions cutanées irréversibles — y compris la production de ce changement —, à savoir une nécrose visible au travers de l’épiderme et dans le derme, notamment les ulcérations, les saignements, les escarres ensanglantées et, dans une période d’observation de quatorze jours, la décoloration due au blanchissement de la peau, les zones complètes d’alopécie et les cicatrices.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Dangers physiques non classifiés ailleurs (DPNCA)",
                Definition = "Les produits dangereux regroupés dans cette classe de dangers présentent un danger physique différent de tout autre danger physique traité dans le RPD.Ces dangers doivent avoir la caractéristique de survenir par réaction chimique et de causer des blessures graves ou la mort lorsque la réaction se produit.Si un produit est classé dans cette classe de dangers, la mention de dangers sur l'étiquette et la fiche de données de sécurité décrira la nature du danger.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Dangers pour la santé non classifiés ailleurs (DSNCA)",
                Definition = "Les produits dangereux regroupés dans cette classe de dangers présentent un danger pour la santé différent de tout autre danger pour la santé traité dans le RPD.Ces dangers doivent avoir la caractéristique de survenir après une exposition aigüe ou répétée et d'avoir un effet nocif sur la santé d'une personne y étant exposée, y compris une blessure, ou de causer la mort.Si un produit est classé dans cette classe de dangers, la mention de dangers sur l'étiquette et la fiche de données de sécurité décrira la nature du danger.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Dénomination chimique",
                Definition = "Appellation scientifique d’une matière ou d’une substance conforme aux systèmes de nomenclature du Chemical Abstracts Service, division de l’American Chemical Society, ou de l’Union internationale de chimie pure et appliquée, ou autre appellation scientifique reconnue à l’échelle internationale qui identifie clairement la matière ou la substance.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "DL50",
                Definition = "Dose unique d’un mélange ou d’une substance qui, lorsqu’elle est administrée par une voie d’exposition précise dans le cadre d’une expérimentation animale, est censée provoquer la mort de 50, 0 % d’une population donnée d’animaux.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "DL50",
                Definition = "Dose unique d’un mélange ou d’une substance qui, lorsqu’elle est administrée par une voie d’exposition précise dans le cadre d’une expérimentation animale, est censée provoquer la mort de 50, 0 % d’une population donnée d’animaux.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Document",
                Definition = "Tout support sur lequel sont enregistrés ou inscrits des renseignements pouvant être compris par un individu ou lus par un ordinateur ou tout autre dispositif.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Effets narcotiques",
                Definition = "Dépression du système nerveux central qui :a) chez l’être humain, peut se manifester sous forme de torpeur, narcose, diminution de la vigilance, perte de réflexes, manque de coordination, vertige, violents maux de tête ou nausée, et peut entraîner une altération du jugement, des étourdissements, de l’irritabilité, de la fatigue, des troubles de la mémoire, un déficit au niveau des perceptions ou de la coordination, un temps de réaction prolongé ou de la somnolence; b) chez les animaux, peut être constaté par l’observation d’une léthargie, d’un manque de réflexe coordonné de redressement, d’une narcose ou d’une ataxie.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Effets néfastes sur la fonction sexuelle et la fertilité",
                Definition = "Effets d’un mélange ou d’une substance qui sont susceptibles d’interférer avec la fonction sexuelle ou la fertilité, notamment :\n" +
                                "\ta) les altérations du système reproducteur mâle ou femelle;\n" +
                                "\tb) les effets néfastes sur le commencement de la puberté, sur la production ou le transport de gamètes, sur le cycle reproducteur, sur le comportement sexuel, sur la parturition ou sur les résultats de la gestation;\n" +
                                "\tc) la sénescence reproductive prématurée;\n" +
                                "\td) les modifications d’autres fonctions qui dépendent de l’intégrité du système reproducteur.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Effets néfastes sur le développement de l’embryon, du foetus ou de la progéniture",
                Definition = "Effets néfastes d’un mélange ou d’une substance sur l’embryon, le foetus ou la progéniture qui résultent soit de l’exposition d’un des deux parents avant la conception, soit de l’exposition de l’embryon ou du foetus au cours de son développement prénatal ou de la progéniture au cours de son développement postnatal jusqu’à sa maturation sexuelle, qui peuvent apparaître à n’importe quel stade du développement de l’embryon ou du foetus ou à n’importe quel stade de la vie de la progéniture et qui se manifestent notamment par la perte de l’embryon ou du foetus, la mort de la progéniture en développement, des anomalies structurelles, des anomalies de croissance et des déficiences fonctionnelles.La présente définition exclut les effets génétiques héréditaires chez la progéniture.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Effets sur ou via l’allaitement",
                Definition = "S’entend :\n" +
                "\ta) soit de l’effet d’un mélange ou d’une substance qui interfère avec la lactation;\n" +
                "\tb) soit de la présence du mélange ou de la substance, ou de leurs métabolites, dans le lait maternel en une quantité pour laquelle des preuves appuient la conclusion, selon les principes scientifiques reconnus, selon laquelle ils sont susceptibles de menacer la santé du nourrisson ou de l’animal allaité.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "ETA",
                Definition = "Estimation de la toxicité aiguë, y compris la DL50 et la CL50 ainsi que la valeur ponctuelle de l’estimation de la toxicité aiguë déterminée conformément au tableau de l’article 8.1.7.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Étiquette",
                Definition = "Ensemble d’éléments d’information écrits, imprimés ou graphiques relatifs à un produit dangereux, conçu pour être apposé, imprimé, écrit ou fixé sur ce produit ou sur le contenant qui le renferme.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Expédition en vrac",
                Definition = "S’entend de l’expédition d’un produit dangereux sans aucun moyen intermédiaire de confinement ni emballage intermédiaire, dans l’un des contenants suivants :\n" +
                                "\ta) un récipient ayant une capacité en eau de 450 l et plus;\n" +
                                "\tb) un conteneur de fret, un véhicule routier, un véhicule ferroviaire, une citernemobile;\n" +
                                "\tc) une cale de navire;\n" +
                                "\td) un pipeline.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Fabricant",
                Definition = "Fournisseur qui, dans le cadre de ses activités au Canada, fabrique, produit, traite, emballe ou étiquette un produit dangereux et le vend.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Fiche de données de sécurité",
                Definition = "Document qui contient, sous les rubriques devant y figurer en application des règlements pris en vertu du paragraphe 15(1), des renseignements sur un produit dangereux, notamment sur les dangers associés à son utilisation, à sa manutention ou à son stockage dans le lieu de travail.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Fournisseur",
                Definition = "Personne qui, dans le cadre de ses affaires, importe ou vend des produits dangereux.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Gaz",
                Definition = "Mélange ou substance qui possède l’une ou l’autre des caractéristiques suivantes :a) il exerce, à 50 °C, une pression de vapeur absolue supérieure à 300 kPa; b) il est complètement gazeux à 20 °C et à la pression normale de 101,3 kPa.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Gaz comburantsliquides comburants oumatières solides comburantes",
                Definition = "Les produits dangereux regroupés dans cette classe de dangers peuvent causer ou intensifier un incendie, ou causer un incendie ou une explosion.Les gaz comburants sont plus susceptibles que l'air de causer la combustion d'autres matières ou d'y contribuer.Les liquides comburants et les matières solides comburantes sont susceptibles de causer la combustion d'autres matières ou d'y contribuer.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Gaz inflammables",
                Definition = "Les produits dangereux qui sont regroupés dans cette classe de dangers sont des gaz qui présentent une zone d'inflammabilité lorsqu'ils sont mêlés à l'air (à 20 °C et 101, 3 kPa).",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Gaz pyrophoriquesliquides pyrophoriques oumatières solides pyrophoriques",
                Definition = "Les produits dangereux regroupés dans ces classes de dangers peuvent prendre feu spontanément(très rapidement) s'ils sont exposés à l'air.Les liquides pyrophoriques et les matières solides pyrophoriques sont susceptibles de s'enflammer moins de cinq minutes après être entrés en contact avec l'air. Les gaz pyrophoriques sont susceptibles de s'enflammer spontanément dans l'air à une température de 54 °C ou moins.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Gaz sous pression",
                Definition = "Les produits dangereux regroupés dans cette classe de dangers sont les gaz comprimés, les gaz liquéfiés, les gazdissous ou les gaz liquéfiés réfrigérés.Les gaz comprimés, les gaz liquéfiés et les gaz dissouts peuvent exploser s'ils sont chauffés.Les gaz liquéfiés réfrigérés peuvent causer des brûlures ou des blessures cryogéniques",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Générateur d’aérosol",
                Definition = "Récipient non rechargeable fait de métal, de verre ou de plastique, contenant un gaz comprimé, liquéfié ou dissous sous pression, avec ou sans liquide, mousse, pâte, gel ou poudre, et muni d’un dispositif de détente permettant d’en expulser le contenu sous forme de particules solides ou liquides en suspension dans un gaz, ou sous forme de mousse, de pâte, de gel ou de poudre ou encore à l’état liquide ou gazeux.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Génotoxicité",
                Definition = "Altération de la structure, du contenu informationnel ou de la ségrégation de l’ADN par un agent ou un processus, notamment ceux qui endommagent l’ADN en interférant avec le processus normal de réplication ou qui altèrent temporairement, de façon non physiologique, sa réplication.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Identificateur de produit",
                Definition = "La marque, la dénomination chimique ou l’appellation courante, commerciale ou générique d’un produit dangereux.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Identificateur du fournisseur initial",
                Definition = "Les nom, adresse et numéro de téléphone :\n" +
                                "\ta) soit du fabricant;\n" +
                                "\tb) soit de l’importateur du produit dangereux qui exerce des activités au Canada.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Importer",
                Definition = "Importer au Canada.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Inflammable",
                Definition = "Qui peut s'enflammer (prendre feu) facilement.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Ingrédient dangereux",
                Definition = "Ingrédient faisant partie d’un mélange qui est classé dans une catégorie ou sous - catégorie d’une classe de danger pour la santé lorsqu’il est évalué en tant que substance individuelle.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Inspecteur",
                Definition = "Individu désigné à ce titre en application du paragraphe 21(1).",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Irritant pour la peau",
                Definition = "Se dit d’un mélange ou d’une substance susceptible de causer une irritation cutanée.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Irritation cutanée",
                Definition = "Apparition de lésions cutanées réversibles, y compris la production de ce changement.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Irritation des voies respiratoires",
                Definition = "Rougeur locale, oedème, prurit ou effet irritant, dans les voies respiratoires, qui en altèrent le fonctionnement, qu’ils soient ou non accompagnés de toux, de douleurs, d’étouffement, de difficultés respiratoires ou d’autres symptômes respiratoires.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Irritation oculaire",
                Definition = "Irritation de l’oeil — y compris la production de ce changement — qui est totalement réversible pendant une période d’observation de vingt et un jours.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Lésion oculaire grave",
                Definition = "Lésion des tissus oculaires ou dégradation physique sévère de la vue — y compris la production de ce changement — soit pour laquelle il existe des données démontrant qu’elle est irréversible, soit qui n’est pas totalement réversible pendant une période d’observation de vingt et un jours.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Lieu de travail",
                Definition = "Lieu où une personne travaille moyennant rémunération.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Liquide",
                Definition = "Mélange ou substance qui possède les caractéristiques suivantes :\n" +
                                "\ta) il exerce, à 50 °C, une pression de vapeur inférieure ou égale à 300 kPa;\n" +
                                "\tb) il n’est pas complètement gazeux à 20 °C et à la pression normale de 101,3 kPa;\n" +
                                "\tc) son point de fusion ou son point initial de fusion est inférieur ou égal à 20 °C à la pression normale de 101,3 kPa ou, si aucun des deux points ne peut être déterminé :\n" +
                                "\t(i) soit il est un liquide, selon les résultats de l’épreuve décrite dans la méthode D4359-90 de la société ASTM International intitulée Standard Test Method for Determining Whether a Material Is a Liquid or a Solid, avec ses modifications successives,\n" +
                                "\t(ii) soit il est non pâteux, selon les résultats de l’épreuve pour déterminer la fluidité — ou épreuve du pénétromètre — prévue à la section 4 du chapitre 3 de la partie 2, numérotée 2.3.4, de l’annexe A de l’Accord européen relatif au transport international des marchandises dangereuses par route, avec ses modifications successives.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Liquides combustibles",
                Definition = "Les liquides combustibles font partie de la classe de dangers des liquides inflammables. Les liquides combustibles ne s'enflammeront pas ou ne brûleront pas aussi rapidement que les liquides inflammables.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Liquide inflammable",
                Definition = "Liquide dont le point d’éclair ne dépasse pas 93 °C.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Loi sur les produits dangereux/Règlement sur les produits dangereux",
                Definition = "Le Règlement sur les produits dangereux (RPD) est un règlement canadien établi en vertu de la Loi sur les produits dangereux",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Manuel d’épreuves et de critères",
                Definition = "Publication des Nations Unies intitulée Recommandations relatives au transport des marchandises dangereuses — Manuel d’épreuves et de critères, avec ses modifications successives.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mélange",
                Definition = "Combinaison d’au moins deux ingrédients ne réagissant pas entre eux et qui n’est pas une substance ou solution qui est composée d’au moins deux de ces ingrédients et qui n’est pas une substance.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mélange complexe",
                Definition = "S’entend du mélange qui a une appellation générique généralement connue et qui est :\n" +
                                "\ta) soit d’origine naturelle;\n" +
                                "\tb) soit une fraction d’un mélange d’origine naturelle qui résulte d’un procédé de séparation;\n" +
                                "\tc) soit une modification d’un mélange d’origine naturelle ou une modification d’une fraction de celui-ci qui résulte d’un procédé de modification chimique.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mention d’avertissement",
                Definition = "Relativement à un produit dangereux, mot, soit « Danger » soit « Attention », signalant au lecteur l’existence d’un danger potentiel et indiquant sa gravité.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mention de danger",
                Definition = "Phrase attribuée à une catégorie ou à une sous-catégorie d’une classe de danger ou, dans le cas de la colonne 5 des parties 4 à 6 de l’annexe 5, Phrase attribuée à une catégorie ou à une sous-catégorie d’une classe de danger ou, dans le cas de la colonne 5 des parties 4 à 6 de l’annexe 5, l’énoncé exigé, qui décrit la nature du danger que présente un produit dangereux. l’énoncé exigé, qui décrit la nature du danger que présente un produit dangereux.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mesures à prendre en cas de déversement accidentel",
                Definition = "Étapes à suivre en cas de déversement, fuite ou autre émission d'un produit dangereux pour éviter ou limiter les effets néfastes sur les gens ou les biens.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Méthode validée sur le plan scientifique",
                Definition = "À l’égard d’un danger, méthode spécifiant des normes pour évaluer ce danger dont les résultats sont exacts et reproductibles, conformément aux principes scientifiques reconnus.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Ministre",
                Definition = "Le ministre de la Santé.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mutagène",
                Definition = "Mélange ou substance susceptible d’entraîner une augmentation de la fréquence des mutations dans des populations de cellules ou d’organismes.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mutagène des cellules germinales",
                Definition = "Mélange ou substance susceptible d’entraîner une augmentation de la fréquence des mutations dans les cellules germinales d’une population.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mutagénicité",
                Definition = "Augmentation de la fréquence des mutations dans des populations de cellules ou d’organismes.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Mutation",
                Definition = "Changement permanent ayant un effet sur la quantité ou la structure du matériel génétique d’une cellule.La présente définition vise notamment :a) les changements génétiques héréditaires qui peuvent se manifester au niveau phénotypique; b) les modifications sous - jacentes de l’ADN lorsque celles - ci sont connues, notamment les changements portant sur une paire de bases déterminée et les translocations chromosomiques.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Nouvelles données importantes",
                Definition = "S’entend de toutes les nouvelles données sur les dangers que présente le produit dangereux, qui entraînent une modification de sa classification dans une catégorie ou une sous - catégorie d’une classe de danger ou sa classification dans une autre classe de danger ou qui modifient les moyens de se protéger contre ces dangers.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Numéro d’enregistrement CAS",
                Definition = "Numéro d’identification attribué à un produit chimique par le Chemical Abstracts Service, division de l’American Chemical Society.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Numéro ONU",
                Definition = "Numéro d’identification à quatre chiffres attribué conformément au Règlement type des Nations Unies.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "OCDE",
                Definition = "L’Organisation de coopération et de développement économiques.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Organe",
                Definition = "Est assimilé à un organe tout système biologique.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Peroxydes organiques",
                Definition = "Les produits dangereux regroupés dans cette classe de dangers sont réactifs et peuvent causer un incendie ou une explosion s'ils sont chauffés. Le peroxyde organique est un liquide ou un solide organique(contient du carbone) qui comprend deux atomes d'oxygène joints ensemble (la structure bivalente « 0 - 0 »).",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Personne",
                Definition = "Individu ou organisation au sens de l’article 2 du Code criminel.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Point d’ébullition initial",
                Definition = "Température à laquelle la pression de vapeur d’un liquide est égale à la pression normale de 101, 3 kPa, c’est - à - dire la température à laquelle apparaît la première bulle de vapeur dans le liquide.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Point d’éclair",
                Definition = "Température minimale, ramenée à la pression normale de 101, 3 kPa, à laquelle les vapeurs d’un liquide s’enflamment lorsqu’elles sont exposées à une source d’ignition.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Poussières",
                Definition = "Particules solides en suspension dans un gaz, généralement l’air.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Produit dangereux",
                Definition = "Produit, mélange, matière ou substance classés conformément aux règlements pris en vertu du paragraphe 15(1) dans une des catégories ou sous - catégories des classes de danger inscrites à l’annexe 2.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Produit de combustion dangereux",
                Definition = "Substances dangereuses formées lorsque le produit brûle. Ces substances peuvent être inflammables, toxiques et réactives ou peuvent présenter d'autres dangers.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Produit de décomposition dangereux",
                Definition = "Substance dangereuse qui peut être libérée d'un produit en raison de son vieillissement, d'un contact avec l'oxygène, de la présence d'humidité ou d'une exposition à la lumière.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Propriétés explosives",
                Definition = "Propriétés que possède une matière autoréactive si, lors d’épreuves de laboratoire effectuées conformément aux épreuves des séries A, C ou E de la deuxième partie du Manuel d’épreuves et de critères, elle se révèle susceptible de détoner, de déflagrer rapidement ou de réagir violemment à un chauffage sous confinement.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Règlement type des Nations Unies",
                Definition = "Publication des Nations Unies intitulée Recommandations relatives au transport des marchandises dangereuses — Règlement type, avec ses modifications successives.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Sensibilisant cutané",
                Definition = "Mélange ou substance susceptible d’entraîner une réaction allergique après un contact avec la peau.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Sensibilisant respiratoire",
                Definition = "Mélange ou substance dont l’inhalation est susceptible d’entraîner une hypersensibilité des voies respiratoires.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Sensibilisation cutanée",
                Definition = "Mélange ou substance dont l’inhalation est susceptible d’entraîner une hypersensibilité des voies respiratoires.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Sensibilisation respiratoire",
                Definition = "Production d’une hypersensibilité des voies respiratoires après inhalation.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "SGH",
                Definition = "Cinquième édition révisée de la publication des Nations Unies intitulée Système général harmonisé de classification et d’étiquetage des produits chimiques.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Solide",
                Definition = "Mélange ou substance qui n’est ni un liquide ni un gaz.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Solide facilement inflammable",
                Definition = "Mélange ou substance pulvérulent, granulaire ou pâteux qui prend feu facilement au contact bref d’une source d’inflammation et dont la flamme, lorsqu’il prend feu, se propage rapidement.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Solide inflammable",
                Definition = "Solide facilement inflammable ou susceptible de provoquer ou d’aggraver un incendie par frottement.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Substance",
                Definition = "Tout élément chimique ou composé chimique — à l’état naturel ou obtenu grâce à un procédé de production — qu’il soit présent isolément ou combiné à un additif pour en préserver la stabilité, ou à un solvant pour en préserver la stabilité ou la composition, ou à toute impureté issue du procédé de production.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "TDAA ou température de décomposition autoaccélérée",
                Definition = "Température minimale à laquelle une décomposition autoaccélérée survient.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Tel qu’il est emballé",
                Definition = "Sous la forme et dans la condition prévues par les épreuves des séries B, D, G et H de la deuxième partie du Manuel d’épreuves et de critères.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Toxicité aiguë",
                Definition = "Manifestation d’effets néfastes :\n" +
                                "\ta) soit après administration, par voie orale ou cutanée, d’une dose unique d’un mélange ou d’une substance ou de plusieurs doses réparties sur un intervalle de temps de vingt - quatre heures;\n" +
                                "\tb) soit à la suite d’une exposition par inhalation à un mélange ou à une substance d’une durée de quatre heures ou d’une durée qui a été convertie à quatre heures, conformément au paragraphe 8.1.1(4).",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Toxicité pour certains organes cibles – exposition unique",
                Definition = "Les produits dangereux regroupés dans cette classe de dangers causent ou peuvent causer des dommages à certains organes(c.- à - d.foie, reins ou sang) après une exposition unique au produit.Cette classe de dangers comprend aussi une catégorie de produits qui causent une irritation respiratoire transitoire(temporaire), ou de la somnolence ou des étourdissements transitoires (temporaires).La toxicité pour certains organes cibles résultant d'une exposition unique à un produit dangereux signifie des effets toxiques non létaux sur les organes en question, qui découlent de l'exposition unique à un produit dangereux, y compris tous les effets sur la santé susceptibles de diminuer les fonctions du corps ou de ses parties, réversibles ou non, immédiats ou retardés.Cette classe de dangers ne comprend pas les dangers pour la santé qui sont traités dans les classes suivantes : toxicité aigüe; corrosion cutanée/ irritation cutanée; lésions oculaires graves / irritation oculaire; sensibilisation respiratoire ou cutanée; mutagénicité sur les cellules germinales;cancérogénicité; toxicité reproductive; danger par aspiration.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Toxicité pour certains organes cibles – expositions répétées",
                Definition = "Les produits dangereux regroupés dans cette classe de dangers causent ou peuvent causer des dommages à certains organes(c.- à - d.foie, reins ou sang) après une exposition prolongée ou répétée au produit.La toxicité pour certains organes cibles résultant d'une exposition répétée signifie des effets toxiques précis sur les organes en question, qui découlent de l'exposition répétée à un produit dangereux, y compris tous les effets sur la santé susceptibles de diminuer les fonctions du corps ou de ses parties, réversibles ou non, immédiats ou retardés.Cette classe de dangers ne comprend pas les dangers pour la santé qui sont traités dans les classes suivantes : toxicité aigüe; corrosion cutanée/ irritation cutanée; lésions oculaires graves / irritation oculaire; sensibilisation respiratoire ou cutanée; mutagénicité sur les cellules germinales; cancérogénicité; toxicité reproductive; danger par aspiration.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Toxicité pour la reproduction",
                Definition = "Manifestation de l’un des effets suivants :\n" +
                                "\ta) les effets néfastes sur la fonction sexuelle et la fertilité;\n " +
                                "\tb) les effets néfastes sur le développement de l’embryon, du foetus ou de la progéniture;\n " +
                                "\tc) les effets sur ou via l’allaitement.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Toxique aigu",
                Definition = "Mélange ou substance susceptible de causer une toxicité aiguë ou qui, au contact de l’eau, dégage une substance gazeuse susceptible de causer une toxicité aiguë.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Toxique pour la reproduction",
                Definition = "Se dit d’un mélange ou d’une substance susceptible d’entraîner une toxicité pour la reproduction.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Transit",
                Definition = "S’entend du transport d’un produit dangereux via le Canada, après l’importation et avant l’exportation, lorsque le point de chargement initial et la destination finale sont à l’étranger, et, au cours du transport, de son chargement, de son déchargement, de son emballage, de son déballage ou de son stockage.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Vapeur",
                Definition = "Forme gazeuse d’un mélange ou d’une substance qui est libérée à partir de son état liquide ou solide.",
                
            });
            Glossary.Add(new GlossaryItem
            {
                Element = "Vendre",
                Definition = "Est notamment assimilé à l’acte de vendre le fait d’effectuer une offre de vente ou de distribution, d’exposer ou d’avoir en sa possession pour la vente ou la distribution, de distribuer à un ou plusieurs destinataires, que la distribution soit faite ou non pour une contrepartie, ou encore le transfert de possession constituant un baillement ou, au Québec, le transfert de détention d’un bien meuble, dans un but précis, sans transfert de propriété et avec l’obligation de remettre le bien au propriétaire ou à une personne précise, notamment le transfert effectué dans le cadre d’un contrat de dépôt, d’un contrat de louage, d’un gage,d’un prêt à usage ou d’un contrat de transport.",
                
            });

            #endregion





        }
    }
}
