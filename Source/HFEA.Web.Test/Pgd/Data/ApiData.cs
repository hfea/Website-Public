using HFEA.Connector.Contracts.CommonObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Web.Test.Pgd.Data
{
    public class ApiData
    {
        public static List<IdNameDescription> FullList
        {
            get
            {
                return JsonConvert.DeserializeObject<List<IdNameDescription>>(fullList);
            }
        }

        private const string fullList = @"
[
  {
    ""id"": 2882,
    ""name"": ""(PIGN gene) Multiple Congenital Anomalies Hypotonia – Seizures Syndrome 1"",
    ""description"": ""614080"",
    ""helpText"": null
  },
  {
    ""id"": 2986,
    ""name"": ""Abetalipoproteinemia (also known as aconthocytosis, microsomal triglyceride transfer protein deficiency and Bassen-Kornweig syndrome)"",
    ""description"": ""200100"",
    ""helpText"": null
  },
  {
    ""id"": 2971,
    ""name"": ""Achondrogenesis Type 1a"",
    ""description"": ""600972"",
    ""helpText"": null
  },
  {
    ""id"": 2912,
    ""name"": ""Achondroplasia"",
    ""description"": ""100800"",
    ""helpText"": null
  },
  {
    ""id"": 2784,
    ""name"": ""Alagille Syndrome"",
    ""description"": ""118450"",
    ""helpText"": null
  },
  {
    ""id"": 2787,
    ""name"": ""Alpha Thalassemia"",
    ""description"": ""141800"",
    ""helpText"": null
  },
  {
    ""id"": 2939,
    ""name"": ""Alport Syndrome "",
    ""description"": ""203780"",
    ""helpText"": null
  },
  {
    ""id"": 2863,
    ""name"": ""Alports Syndrome (Autosomal Dominant) "",
    ""description"": ""104200"",
    ""helpText"": null
  },
  {
    ""id"": 2605,
    ""name"": ""Alzheimer's Disease - early onset (Type 3 and 4)"",
    ""description"": ""607822/ 606889"",
    ""helpText"": null
  },
  {
    ""id"": 2932,
    ""name"": ""Anauxetic Dysplasia"",
    ""description"": ""607095"",
    ""helpText"": null
  },
  {
    ""id"": 2618,
    ""name"": ""Angelman Syndrome (UBE3A gene only)"",
    ""description"": ""105830"",
    ""helpText"": null
  },
  {
    ""id"": 2957,
    ""name"": ""Aniridia"",
    ""description"": ""106210"",
    ""helpText"": null
  },
  {
    ""id"": 2601,
    ""name"": ""Argininosuccinic Aciduria"",
    ""description"": ""207900"",
    ""helpText"": null
  },
  {
    ""id"": 2952,
    ""name"": ""Arthrogryposis renal dysfunction and cholestasis type 1 and type 2 "",
    ""description"": ""208085, 613404"",
    ""helpText"": null
  },
  {
    ""id"": 2884,
    ""name"": ""Autosomal Dominant Acute Necrotizing Encephalopathy "",
    ""description"": ""608033"",
    ""helpText"": null
  },
  {
    ""id"": 2964,
    ""name"": ""Autosomal dominant familial exudative vitreoretinopathy types 1, 5 and 4,"",
    ""description"": ""133780, 613310, 601813"",
    ""helpText"": null
  },
  {
    ""id"": 2726,
    ""name"": ""Autosomal Recessive Dopa Responsive Dystonia"",
    ""description"": ""233910"",
    ""helpText"": null
  },
  {
    ""id"": 2623,
    ""name"": ""Bardet-Biedl Syndrome (BBS)  "",
    ""description"": ""209900"",
    ""helpText"": null
  },
  {
    ""id"": 2970,
    ""name"": ""Bartter Syndrome, Types 1, 2, 3, 4a & 4b"",
    ""description"": ""601678, 241200, 607364, 602522, 613090"",
    ""helpText"": null
  },
  {
    ""id"": 2975,
    ""name"": ""Bloom Syndrome"",
    ""description"": ""210900"",
    ""helpText"": null
  },
  {
    ""id"": 2567,
    ""name"": ""Calpainopathy"",
    ""description"": ""253600"",
    ""helpText"": null
  },
  {
    ""id"": 2563,
    ""name"": ""Canavan Disease"",
    ""description"": ""271900"",
    ""helpText"": null
  },
  {
    ""id"": 2788,
    ""name"": ""Carnitine Acylcarnitine Translocase Deficiency (CACT)"",
    ""description"": ""212138"",
    ""helpText"": null
  },
  {
    ""id"": 2933,
    ""name"": ""Cartilage-Hair Hypoplasia"",
    ""description"": ""250250"",
    ""helpText"": null
  },
  {
    ""id"": 2936,
    ""name"": ""Cartilage-hair hypoplasia spectrum"",
    ""description"": ""157660 "",
    ""helpText"": null
  },
  {
    ""id"": 2879,
    ""name"": ""Catecholaminergic Polymorphic Ventricular Tachycardia (CPVT1) "",
    ""description"": ""604772"",
    ""helpText"": null
  },
  {
    ""id"": 2606,
    ""name"": ""Catecholaminergic Polymorphic Ventricular Tachychardia 2 (CPVT2)"",
    ""description"": ""611938"",
    ""helpText"": null
  },
  {
    ""id"": 2562,
    ""name"": ""Charcot Marie Tooth Disease Type 2 "",
    ""description"": ""609260"",
    ""helpText"": null
  },
  {
    ""id"": 2603,
    ""name"": ""Charcot Marie Tooth Disease, demyelinating type 1A (CMT1A)"",
    ""description"": ""118220"",
    ""helpText"": null
  },
  {
    ""id"": 2894,
    ""name"": ""CHARGE Syndrome "",
    ""description"": ""214800"",
    ""helpText"": null
  },
  {
    ""id"": 2969,
    ""name"": ""Christianson syndrome"",
    ""description"": ""300243"",
    ""helpText"": null
  },
  {
    ""id"": 2554,
    ""name"": ""Classical Ehlers Danlos Syndrome"",
    ""description"": ""130000/130010"",
    ""helpText"": null
  },
  {
    ""id"": 2890,
    ""name"": ""Cohen Syndrome"",
    ""description"": ""216550"",
    ""helpText"": null
  },
  {
    ""id"": 2976,
    ""name"": ""Congenital Contractual Arachnodactyly (Beals Syndrome)"",
    ""description"": ""121050"",
    ""helpText"": null
  },
  {
    ""id"": 2991,
    ""name"": ""Congenital contractual syndrome 7"",
    ""description"": ""616286"",
    ""helpText"": null
  },
  {
    ""id"": 2888,
    ""name"": ""Congenital Disorder of Glycosylation type 1a "",
    ""description"": ""212065"",
    ""helpText"": null
  },
  {
    ""id"": 2989,
    ""name"": ""Congenital Dyserythropoietic Anaemia types 1a, 1b and 2"",
    ""description"": ""224120, 615631, 224100"",
    ""helpText"": null
  },
  {
    ""id"": 2880,
    ""name"": ""Congenital Myasthenic Syndrome (COLQ gene 603033) (Type Ic)"",
    ""description"": ""603034"",
    ""helpText"": null
  },
  {
    ""id"": 2889,
    ""name"": ""Congenital Secretory Chloride Diarrhoea "",
    ""description"": ""214700"",
    ""helpText"": null
  },
  {
    ""id"": 2727,
    ""name"": ""Conradi-Hunermann-Happle Syndrome"",
    ""description"": ""302960"",
    ""helpText"": null
  },
  {
    ""id"": 2875,
    ""name"": ""Craniofrontal Dysplasia"",
    ""description"": ""304110"",
    ""helpText"": null
  },
  {
    ""id"": 2407,
    ""name"": ""Czech Dysplasia, metatarsal type also known as Progressive pseudorheumatoid dysplasia with hypoplastic toes"",
    ""description"": ""609162"",
    ""helpText"": null
  },
  {
    ""id"": 2620,
    ""name"": ""Dentatorubral-Pallidoluysian Atrophy (DRPLA)"",
    ""description"": ""125370"",
    ""helpText"": null
  },
  {
    ""id"": 2874,
    ""name"": ""Desbuquois Dysplasia (DBQD)"",
    ""description"": ""251450"",
    ""helpText"": null
  },
  {
    ""id"": 2408,
    ""name"": ""Diamond Blackfan Anaemia*"",
    ""description"": ""105650"",
    ""helpText"": null
  },
  {
    ""id"": 2877,
    ""name"": ""Diarrheoa 5 with tufting enteropathy congenital"",
    ""description"": ""613217"",
    ""helpText"": null
  },
  {
    ""id"": 2972,
    ""name"": ""Dilated Cardiomyopathy caused by a mutation in the Tropomyosin alpha-1 chain"",
    ""description"": ""611878"",
    ""helpText"": null
  },
  {
    ""id"": 2977,
    ""name"": ""Dilated Cardiomyopathy type 1A caused by a mutation in the LMNA gene"",
    ""description"": ""115200"",
    ""helpText"": null
  },
  {
    ""id"": 2878,
    ""name"": ""Distal Hereditary Motor Neuropathy type IIB"",
    ""description"": ""608634"",
    ""helpText"": null
  },
  {
    ""id"": 2979,
    ""name"": ""Distal Renal Tubular Acidosis with progressive nerve deafness"",
    ""description"": ""602722, 267300"",
    ""helpText"": null
  },
  {
    ""id"": 2409,
    ""name"": ""Dominant Dystrophic Epidermolysis Bullosa"",
    ""description"": ""131750"",
    ""helpText"": null
  },
  {
    ""id"": 2622,
    ""name"": ""Donohue Syndrome"",
    ""description"": ""246200"",
    ""helpText"": null
  },
  {
    ""id"": 2410,
    ""name"": ""Downs Syndrome"",
    ""description"": ""190685"",
    ""helpText"": null
  },
  {
    ""id"": 2602,
    ""name"": ""Dravet Syndrome "",
    ""description"": ""607208"",
    ""helpText"": null
  },
  {
    ""id"": 2561,
    ""name"": ""Dyskeratosis congenita (Male embryos only)"",
    ""description"": ""305000"",
    ""helpText"": null
  },
  {
    ""id"": 2974,
    ""name"": ""Dyskeratosis Congenita due to TERC mutation"",
    ""description"": ""127550"",
    ""helpText"": null
  },
  {
    ""id"": 2411,
    ""name"": ""Dystonia 1 Torsion Autosomal Dominant (DYT1)"",
    ""description"": ""128100"",
    ""helpText"": null
  },
  {
    ""id"": 2412,
    ""name"": ""Ectodermal dysplasia (Hypohidrotic)"",
    ""description"": ""305100 "",
    ""helpText"": null
  },
  {
    ""id"": 2413,
    ""name"": ""Ectrodactyly, Ectodermal Dysplasia, Clefting Syndrome (EEC)"",
    ""description"": ""129900"",
    ""helpText"": null
  },
  {
    ""id"": 2414,
    ""name"": ""Ehlers-Danlos Type IV"",
    ""description"": ""130050"",
    ""helpText"": null
  },
  {
    ""id"": 2415,
    ""name"": ""Elastin (ELN)-related Supravalvular Aortic Stenosis"",
    ""description"": ""185500"",
    ""helpText"": null
  },
  {
    ""id"": 2569,
    ""name"": ""Ellis-Van Crevald Syndrome"",
    ""description"": ""225500"",
    ""helpText"": null
  },
  {
    ""id"": 2612,
    ""name"": ""Emery-Dreifuss Muscular Dystrophy (x-linked) (EDMD) (Male embryos only)"",
    ""description"": ""310100"",
    ""helpText"": null
  },
  {
    ""id"": 2958,
    ""name"": ""Epidermolysis bullosa, lethal acantholytic"",
    ""description"": ""609638"",
    ""helpText"": null
  },
  {
    ""id"": 2597,
    ""name"": ""Epilepsy, female restricted, with mental retardation (EFMR)"",
    ""description"": ""300088"",
    ""helpText"": null
  },
  {
    ""id"": 2916,
    ""name"": ""Episodic Ataxia Type 2 "",
    ""description"": ""108500"",
    ""helpText"": null
  },
  {
    ""id"": 2416,
    ""name"": ""Facioscapulohumeral Dystrophy (FSH)"",
    ""description"": ""158900"",
    ""helpText"": null
  },
  {
    ""id"": 2417,
    ""name"": ""Factor XIII deficiency"",
    ""description"": ""613225"",
    ""helpText"": null
  },
  {
    ""id"": 2418,
    ""name"": ""Familial Adenomatous polyposis coli (FAP) "",
    ""description"": ""175100"",
    ""helpText"": null
  },
  {
    ""id"": 2913,
    ""name"": ""Familial Dilated Cardiomyopathy caused by mutations in TROPONIN T2 gene (TNNT2)"",
    ""description"": ""191045"",
    ""helpText"": null
  },
  {
    ""id"": 2775,
    ""name"": ""Familial Dysautonomia"",
    ""description"": ""223900"",
    ""helpText"": null
  },
  {
    ""id"": 2611,
    ""name"": ""Familial Hemophagocytic Lymphohistiocytosis (FHL)"",
    ""description"": ""603553"",
    ""helpText"": null
  },
  {
    ""id"": 2920,
    ""name"": ""Familial Hemophagocytic Lymphohistiocytosis 5 "",
    ""description"": ""613101"",
    ""helpText"": null
  },
  {
    ""id"": 2841,
    ""name"": ""Familial Hypertrophic Cardiomyopathy 4 (CMH4)"",
    ""description"": ""115197"",
    ""helpText"": null
  },
  {
    ""id"": 2927,
    ""name"": ""Familial Hypertrophic Cardiomyopathy type 1, 3, 7 and 10"",
    ""description"": ""192600, 115196, 613690, 608758"",
    ""helpText"": null
  },
  {
    ""id"": 2568,
    ""name"": ""Familial Paranganglioma Syndrome (PGL1)"",
    ""description"": ""168000"",
    ""helpText"": null
  },
  {
    ""id"": 2419,
    ""name"": ""Fanconis Anaemia A*"",
    ""description"": ""607139"",
    ""helpText"": null
  },
  {
    ""id"": 2420,
    ""name"": ""Fanconis Anaemia C*"",
    ""description"": ""227645"",
    ""helpText"": null
  },
  {
    ""id"": 2987,
    ""name"": ""Fetal Akinesia Deformation Sequence (Pena-Shokeir syndrome type 1)"",
    ""description"": ""208150"",
    ""helpText"": null
  },
  {
    ""id"": 2935,
    ""name"": ""Finnish Nephrotic Syndrome"",
    ""description"": ""256300"",
    ""helpText"": null
  },
  {
    ""id"": 2937,
    ""name"": ""Focal Dermal Hypoplasia"",
    ""description"": ""305600"",
    ""helpText"": null
  },
  {
    ""id"": 2421,
    ""name"": ""Fragile X Syndrome (FRAX)"",
    ""description"": ""309550"",
    ""helpText"": null
  },
  {
    ""id"": 2422,
    ""name"": ""Fraser Syndrome"",
    ""description"": ""219000"",
    ""helpText"": null
  },
  {
    ""id"": 2893,
    ""name"": ""FRAXE"",
    ""description"": ""309548"",
    ""helpText"": null
  },
  {
    ""id"": 2786,
    ""name"": ""Fried Syndrome"",
    ""description"": ""300630"",
    ""helpText"": null
  },
  {
    ""id"": 2930,
    ""name"": ""Frontometaphyseal Dysplasia"",
    ""description"": ""305620"",
    ""helpText"": null
  },
  {
    ""id"": 2566,
    ""name"": ""Frontotemporal Dementia"",
    ""description"": ""600274"",
    ""helpText"": null
  },
  {
    ""id"": 2928,
    ""name"": ""Frontotemporal Dementia with Parkinsonism"",
    ""description"": ""607485"",
    ""helpText"": null
  },
  {
    ""id"": 2985,
    ""name"": ""Galactosaemia"",
    ""description"": ""230400"",
    ""helpText"": null
  },
  {
    ""id"": 2842,
    ""name"": ""Galactosialidosis (early infantile and adult/ juvenile types)"",
    ""description"": ""256540"",
    ""helpText"": null
  },
  {
    ""id"": 2423,
    ""name"": ""Gangliosidosis (GM1)"",
    ""description"": ""230500"",
    ""helpText"": null
  },
  {
    ""id"": 2425,
    ""name"": ""Gaucher Disease Type II"",
    ""description"": ""230900"",
    ""helpText"": null
  },
  {
    ""id"": 2424,
    ""name"": ""Gaucher Disease Type III"",
    ""description"": ""231000"",
    ""helpText"": null
  },
  {
    ""id"": 2965,
    ""name"": ""Glanzmann Thrombasthenia"",
    ""description"": ""273800"",
    ""helpText"": null
  },
  {
    ""id"": 2571,
    ""name"": ""Glutaric Acidemia (aciduria)"",
    ""description"": ""231670"",
    ""helpText"": null
  },
  {
    ""id"": 2510,
    ""name"": ""Glycogen Storage Disease II (Pompe Disease (early onset))"",
    ""description"": ""232300"",
    ""helpText"": null
  },
  {
    ""id"": 2426,
    ""name"": ""Glycogen Storage Disease Type Ia"",
    ""description"": ""232200"",
    ""helpText"": null
  },
  {
    ""id"": 2427,
    ""name"": ""Gonadal mosaicism "",
    ""description"": null,
    ""helpText"": null
  },
  {
    ""id"": 2776,
    ""name"": ""Gorlin Syndrome "",
    ""description"": ""109400"",
    ""helpText"": null
  },
  {
    ""id"": 2428,
    ""name"": ""Greig Cephalopolysyndactyly"",
    ""description"": ""175700"",
    ""helpText"": null
  },
  {
    ""id"": 2954,
    ""name"": ""Haemoglobin SC disease"",
    ""description"": ""141900.0038"",
    ""helpText"": null
  },
  {
    ""id"": 2429,
    ""name"": ""Haemophilia A "",
    ""description"": ""306700"",
    ""helpText"": null
  },
  {
    ""id"": 2430,
    ""name"": ""Haemophilia B "",
    ""description"": ""306900"",
    ""helpText"": null
  },
  {
    ""id"": 2432,
    ""name"": ""Hereditary diffuse gastric cancer"",
    ""description"": ""137215"",
    ""helpText"": null
  },
  {
    ""id"": 2649,
    ""name"": ""Hereditary Haemorrhagic Telangiectasia (HTT) or Rendu-Osler-Weber Syndrome"",
    ""description"": ""187300 "",
    ""helpText"": null
  },
  {
    ""id"": 2859,
    ""name"": ""Hereditary Multiple Exostoses Type II"",
    ""description"": ""133701"",
    ""helpText"": null
  },
  {
    ""id"": 2434,
    ""name"": ""Hereditary Nonpolyposis Colorectal Cancer: Lynch Syndrome (for all subtypes)"",
    ""description"": """",
    ""helpText"": null
  },
  {
    ""id"": 2564,
    ""name"": ""Holt Oram Syndrome"",
    ""description"": ""142900"",
    ""helpText"": null
  },
  {
    ""id"": 2892,
    ""name"": ""Homocystinuria"",
    ""description"": ""236200"",
    ""helpText"": null
  },
  {
    ""id"": 2435,
    ""name"": ""Homozygous familial hypercholesterolaemia"",
    ""description"": ""143890"",
    ""helpText"": null
  },
  {
    ""id"": 2437,
    ""name"": ""Huntington Disease (Huntington Chorea) "",
    ""description"": ""143100"",
    ""helpText"": null
  },
  {
    ""id"": 2438,
    ""name"": ""Hydrocephalus"",
    ""description"": ""307000"",
    ""helpText"": null
  },
  {
    ""id"": 2439,
    ""name"": ""Hydroxyisobuyryl CoA Hydrolase Deficiency "",
    ""description"": ""250620"",
    ""helpText"": null
  },
  {
    ""id"": 2440,
    ""name"": ""Hyper IgM Syndrome - Hypogammaglobulinaemia*"",
    ""description"": ""300386"",
    ""helpText"": null
  },
  {
    ""id"": 2441,
    ""name"": ""Hyper-IgE Recurrent Infection Syndrome, Autosomal Dominant"",
    ""description"": ""147060"",
    ""helpText"": null
  },
  {
    ""id"": 2910,
    ""name"": ""Hyperphosphatasia with Mental Retardation Syndrome 4 (HPMRS4) "",
    ""description"": ""615716"",
    ""helpText"": null
  },
  {
    ""id"": 2660,
    ""name"": ""Hypochondroplasia"",
    ""description"": ""146000"",
    ""helpText"": null
  },
  {
    ""id"": 2442,
    ""name"": ""Hypophosphatasia (Infantile/perinatal lethal)"",
    ""description"": ""241500"",
    ""helpText"": null
  },
  {
    ""id"": 2443,
    ""name"": ""Hypophosphatemic Rickets (x-linked dominant) (Xlh)"",
    ""description"": ""307800"",
    ""helpText"": null
  },
  {
    ""id"": 2444,
    ""name"": ""Hypospadias (severe)"",
    ""description"": null,
    ""helpText"": null
  },
  {
    ""id"": 2431,
    ""name"": ""Ichthyosis (Harlequin)"",
    ""description"": ""242500"",
    ""helpText"": null
  },
  {
    ""id"": 2445,
    ""name"": ""Ichthyosis (x-linked)"",
    ""description"": ""308100"",
    ""helpText"": null
  },
  {
    ""id"": 2941,
    ""name"": ""ichthyosis with confetti"",
    ""description"": ""609165"",
    ""helpText"": null
  },
  {
    ""id"": 2988,
    ""name"": ""Ichythosis hystrix of Curth-Macklin"",
    ""description"": ""146590"",
    ""helpText"": null
  },
  {
    ""id"": 2446,
    ""name"": ""Idiopathic Arterial Calcification of Infancy"",
    ""description"": ""208000"",
    ""helpText"": null
  },
  {
    ""id"": 2447,
    ""name"": ""Incontinentia Pigmenti (IP)"",
    ""description"": ""308300"",
    ""helpText"": null
  },
  {
    ""id"": 2873,
    ""name"": ""Infantile Neuroaxonal Dystrophy 1"",
    ""description"": ""256600"",
    ""helpText"": null
  },
  {
    ""id"": 2885,
    ""name"": ""Inflammatory Bowel Disease, Early-onset (IBD28)"",
    ""description"": ""613148/ 612567"",
    ""helpText"": null
  },
  {
    ""id"": 2870,
    ""name"": ""IPEX Syndrome (Immunodeficiency, Polyendocrinopathy and Enteropathy, X-Linked)"",
    ""description"": ""304790"",
    ""helpText"": null
  },
  {
    ""id"": 2959,
    ""name"": ""Joubert Syndrome 5,"",
    ""description"": ""610188"",
    ""helpText"": null
  },
  {
    ""id"": 2992,
    ""name"": ""Joubert Syndrome 6"",
    ""description"": ""610688"",
    ""helpText"": null
  },
  {
    ""id"": 2915,
    ""name"": ""Juvenile Polyposis Syndrome "",
    ""description"": ""174900"",
    ""helpText"": null
  },
  {
    ""id"": 2594,
    ""name"": ""Kearns Sayre Syndrome (KSS)/ Pearsons Marrow-Pancreas Syndrome (PMPS)"",
    ""description"": ""530000/ 557000"",
    ""helpText"": null
  },
  {
    ""id"": 2449,
    ""name"": ""Krabbe Disease"",
    ""description"": ""245200"",
    ""helpText"": null
  },
  {
    ""id"": 2607,
    ""name"": ""L–2-Hydroxyglutaric aciduria"",
    ""description"": ""236792"",
    ""helpText"": null
  },
  {
    ""id"": 2983,
    ""name"": ""Lacrimo-auriculo-dento-digital syndrome"",
    ""description"": ""149730"",
    ""helpText"": null
  },
  {
    ""id"": 2624,
    ""name"": ""Leber Congenital Amaurosis (LCA)"",
    ""description"": ""204000 / 204100"",
    ""helpText"": null
  },
  {
    ""id"": 2963,
    ""name"": ""Leber congenital amaurosis, type 7 (autosomal recessive only) "",
    ""description"": ""613829"",
    ""helpText"": null
  },
  {
    ""id"": 2962,
    ""name"": ""Leber congenital amaurosis, types 3, 4, 5, 6, 8, 9, 10, 12, 13, 14, 15, 16, 17"",
    ""description"": ""604232, 604393, 604537, 613826, 613835, 608553, 611755, 613837, 610612, 612712, 613341, 613843, 6141"",
    ""helpText"": null
  },
  {
    ""id"": 2450,
    ""name"": ""Leber's Hereditary Optic Neuropathy (LHON) / Lebers Optic atrophy"",
    ""description"": ""535000"",
    ""helpText"": null
  },
  {
    ""id"": 2451,
    ""name"": ""Leigh Syndrome (Infantile Subacute Necrotising Encephalopathy)"",
    ""description"": ""185620"",
    ""helpText"": null
  },
  {
    ""id"": 2452,
    ""name"": ""Leigh's (subacute necrotising encephalopathy of childhood)  "",
    ""description"": ""516000; 516002; 516005; 516006"",
    ""helpText"": null
  },
  {
    ""id"": 2453,
    ""name"": ""Lenz Syndrome "",
    ""description"": ""309800"",
    ""helpText"": null
  },
  {
    ""id"": 2454,
    ""name"": ""Lesch Nyan Syndrome "",
    ""description"": ""300322"",
    ""helpText"": null
  },
  {
    ""id"": 2856,
    ""name"": ""Lethal Multiple Pterygium Syndrome (LMPS) "",
    ""description"": ""253290"",
    ""helpText"": null
  },
  {
    ""id"": 2455,
    ""name"": ""Leukocyte Adhesion Deficiency (Type I)*"",
    ""description"": ""116920"",
    ""helpText"": null
  },
  {
    ""id"": 2924,
    ""name"": ""Leukoencephalopathy with Vanishing White Matter"",
    ""description"": ""603896"",
    ""helpText"": null
  },
  {
    ""id"": 2951,
    ""name"": ""Lewy body dementia"",
    ""description"": ""127750"",
    ""helpText"": null
  },
  {
    ""id"": 2456,
    ""name"": ""Li-Fraumeni Syndrome "",
    ""description"": ""151623"",
    ""helpText"": null
  },
  {
    ""id"": 2968,
    ""name"": ""Lissencephaly, type 3 "",
    ""description"": ""611603"",
    ""helpText"": null
  },
  {
    ""id"": 2457,
    ""name"": ""Long Chain 3-hydroxyacyl-CoA Dehydrogenase Deficiency (LCHAD)"",
    ""description"": ""609016"",
    ""helpText"": null
  },
  {
    ""id"": 2565,
    ""name"": ""Long QT Syndrome Types 1, 2, 3, 5 & 6"",
    ""description"": ""192500, 613688, 603830, 613695, 613693 "",
    ""helpText"": null
  },
  {
    ""id"": 2599,
    ""name"": ""Lowe Oculocerebrorenal Syndrome"",
    ""description"": ""309000"",
    ""helpText"": null
  },
  {
    ""id"": 2458,
    ""name"": ""Lymphoproliferative Syndrome"",
    ""description"": ""308240"",
    ""helpText"": null
  },
  {
    ""id"": 2461,
    ""name"": ""Macular Dystrophy (childhood onset - variant of Retinitis pigmentosa)"",
    ""description"": ""312600"",
    ""helpText"": null
  },
  {
    ""id"": 2462,
    ""name"": ""Macular Dystrophy Retinal 2"",
    ""description"": ""608051"",
    ""helpText"": null
  },
  {
    ""id"": 2604,
    ""name"": ""Malignant Infantile Osteopetrosis"",
    ""description"": ""259700"",
    ""helpText"": null
  },
  {
    ""id"": 2774,
    ""name"": ""Maple Syrup Urine Disorder (MSUD)"",
    ""description"": ""248600"",
    ""helpText"": null
  },
  {
    ""id"": 2463,
    ""name"": ""Marfan Syndrome"",
    ""description"": ""154700"",
    ""helpText"": null
  },
  {
    ""id"": 2881,
    ""name"": ""Meckel-Gruber Syndrome Types 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 and 11"",
    ""description"": ""249000, 603194, 607361, 611134, 611561, 612284, 267010, 613885, 614209, 614175 and 615397"",
    ""helpText"": null
  },
  {
    ""id"": 2464,
    ""name"": ""Medium-chain acyl-Co A dehydrogenase"",
    ""description"": ""231680"",
    ""helpText"": null
  },
  {
    ""id"": 2883,
    ""name"": ""Medium-Chain Acyl-CoA Dehydrogenase Deficiency"",
    ""description"": ""201450"",
    ""helpText"": null
  },
  {
    ""id"": 2465,
    ""name"": ""MELAS (Mitochondrial Encephalomyopathy, Lactic Acidosis and Stroke-like episodes) "",
    ""description"": ""590050"",
    ""helpText"": null
  },
  {
    ""id"": 2931,
    ""name"": ""Melnick Needles Syndrome"",
    ""description"": ""309350"",
    ""helpText"": null
  },
  {
    ""id"": 2466,
    ""name"": ""Menkes Syndrome"",
    ""description"": ""309400"",
    ""helpText"": null
  },
  {
    ""id"": 2467,
    ""name"": ""Metachromatic Leukodystrophy"",
    ""description"": ""250100"",
    ""helpText"": null
  },
  {
    ""id"": 2934,
    ""name"": ""Metaphyseal Dysplasia without Hypotrichosis"",
    ""description"": ""250460"",
    ""helpText"": null
  },
  {
    ""id"": 2468,
    ""name"": ""Methylmalonic Aciduria and Homocystinuria"",
    ""description"": ""277400"",
    ""helpText"": null
  },
  {
    ""id"": 2469,
    ""name"": ""Micro Syndrome (WARBM)"",
    ""description"": ""600118"",
    ""helpText"": null
  },
  {
    ""id"": 2956,
    ""name"": ""Microcephaly with or without chorioretinopathy, lymphoedema or mental retardation"",
    ""description"": ""152950"",
    ""helpText"": null
  },
  {
    ""id"": 2900,
    ""name"": ""Mitochodrial Trifunctional Protein Deficiency "",
    ""description"": ""609015"",
    ""helpText"": null
  },
  {
    ""id"": 2978,
    ""name"": ""Mitochondrial Complex 1 Deficiency caused by mutation in ACAD9 gene"",
    ""description"": ""611126"",
    ""helpText"": null
  },
  {
    ""id"": 2876,
    ""name"": ""Mitochondrial DNA Depletion Syndrome 2 (myopathic type)"",
    ""description"": ""609560"",
    ""helpText"": null
  },
  {
    ""id"": 2470,
    ""name"": ""Mucolipidosis type II"",
    ""description"": ""252500"",
    ""helpText"": null
  },
  {
    ""id"": 2471,
    ""name"": ""Mucopolysaccharidosis III (MPS-III) Type B"",
    ""description"": ""252920"",
    ""helpText"": null
  },
  {
    ""id"": 2472,
    ""name"": ""Mucopolysaccharidosis III (MPS-III) Type C"",
    ""description"": ""252940"",
    ""helpText"": null
  },
  {
    ""id"": 2473,
    ""name"": ""Mucopolysaccharidosis III (MPS-III) Type D"",
    ""description"": ""252930"",
    ""helpText"": null
  },
  {
    ""id"": 2940,
    ""name"": ""mucopolysaccharidosis IVA"",
    ""description"": ""253000"",
    ""helpText"": null
  },
  {
    ""id"": 2858,
    ""name"": ""Mucopolysaccharidosis Type I (MPS I)"",
    ""description"": ""607014, 607015, 607016"",
    ""helpText"": null
  },
  {
    ""id"": 2436,
    ""name"": ""Mucopolysaccharidosis Type II (Hunter Syndrome)"",
    ""description"": ""309900"",
    ""helpText"": null
  },
  {
    ""id"": 2524,
    ""name"": ""Mucopolysaccharidosis Type III A  (Sanfilippo syndrome A)"",
    ""description"": ""252900"",
    ""helpText"": null
  },
  {
    ""id"": 2474,
    ""name"": ""Mucopolysaccharidosis Type VI (MPS VI) (Maroteaux-Lamy Syndrome)"",
    ""description"": ""253200"",
    ""helpText"": null
  },
  {
    ""id"": 2895,
    ""name"": ""Muenke Syndrome "",
    ""description"": ""602849"",
    ""helpText"": null
  },
  {
    ""id"": 2887,
    ""name"": ""Multiple acyl-CoA dehydrogenase deficiency (MADD) (also known as glutaric aciduria type II) "",
    ""description"": ""231680"",
    ""helpText"": null
  },
  {
    ""id"": 2476,
    ""name"": ""Multiple Endocrine Neoplasia Type 2A (MEN 2A)"",
    ""description"": ""171400"",
    ""helpText"": null
  },
  {
    ""id"": 2477,
    ""name"": ""Multiple Endocrine Neoplasia type 2B (MEN 2B)"",
    ""description"": ""162300"",
    ""helpText"": null
  },
  {
    ""id"": 2475,
    ""name"": ""Multiple Endocrine Neoplasia Type I"",
    ""description"": ""131100"",
    ""helpText"": null
  },
  {
    ""id"": 2725,
    ""name"": ""Multiple Epiphyseal Dysplasia Type 5 (MED5)"",
    ""description"": ""607078"",
    ""helpText"": null
  },
  {
    ""id"": 2478,
    ""name"": ""Multiple Exostoses"",
    ""description"": ""133700"",
    ""helpText"": null
  },
  {
    ""id"": 2614,
    ""name"": ""Multiple Lentigines Syndrome (LEOPARD Syndrome)"",
    ""description"": ""151100"",
    ""helpText"": null
  },
  {
    ""id"": 2857,
    ""name"": ""Multiple Pterygium Syndrome Lethal Form(LMPS) "",
    ""description"": ""253290"",
    ""helpText"": null
  },
  {
    ""id"": 2480,
    ""name"": ""Muscular Dystrophy (Beckers)"",
    ""description"": ""300376"",
    ""helpText"": null
  },
  {
    ""id"": 2481,
    ""name"": ""Muscular Dystrophy (Duchenne)"",
    ""description"": ""310200"",
    ""helpText"": null
  },
  {
    ""id"": 2482,
    ""name"": ""Muscular Dystrophy (Oculopharangeal)"",
    ""description"": ""164300"",
    ""helpText"": null
  },
  {
    ""id"": 2770,
    ""name"": ""Muscular dystrophy, Limb-Girdle (LGMD) Type 1B"",
    ""description"": ""159001"",
    ""helpText"": null
  },
  {
    ""id"": 2619,
    ""name"": ""Muscular dystrophy-dystroglycanopathy, type A1 (Walker Warburg Syndrome)"",
    ""description"": ""236670"",
    ""helpText"": null
  },
  {
    ""id"": 2479,
    ""name"": ""Muscular dystrophy-dystroglycanopathy, type A3 (muscle-eye-brain disease)"",
    ""description"": ""253280"",
    ""helpText"": null
  },
  {
    ""id"": 2483,
    ""name"": ""Muscular dystrophy-dystroglycanopathy, type A5"",
    ""description"": ""613153"",
    ""helpText"": null
  },
  {
    ""id"": 2967,
    ""name"": ""Muscular dystrophy-dystroglycanopathy, types A2, A4, A6-A8 and A10-A14"",
    ""description"": ""613150, 253800, 613154, 614643 614830, 615041, 615181, 615249, 615287, 615350"",
    ""helpText"": null
  },
  {
    ""id"": 2484,
    ""name"": ""Myoclonic Epilepsy and Ragged Red Fibres (MERRF)"",
    ""description"": """",
    ""helpText"": null
  },
  {
    ""id"": 2966,
    ""name"": ""Myoclonic epilepsy associated with ragged-red fibres (associated mutation, m.8344 A>G in the MTTK gene)"",
    ""description"": ""545000"",
    ""helpText"": null
  },
  {
    ""id"": 2485,
    ""name"": ""Myotonic Dystrophy "",
    ""description"": ""160900"",
    ""helpText"": null
  },
  {
    ""id"": 2486,
    ""name"": ""Myotubular myopathy "",
    ""description"": ""310400/300219"",
    ""helpText"": null
  },
  {
    ""id"": 2922,
    ""name"": ""Nail-Patella Syndrome"",
    ""description"": ""161200"",
    ""helpText"": null
  },
  {
    ""id"": 2919,
    ""name"": ""Nance-Horan Syndrome "",
    ""description"": ""613101"",
    ""helpText"": null
  },
  {
    ""id"": 2938,
    ""name"": ""Nance-Horan Syndrome "",
    ""description"": ""302350"",
    ""helpText"": null
  },
  {
    ""id"": 2714,
    ""name"": ""Nephrogenic Diabetes Insipidus (NDI)"",
    ""description"": ""304800"",
    ""helpText"": null
  },
  {
    ""id"": 2487,
    ""name"": ""Neurofibromatosis type 1"",
    ""description"": ""162200"",
    ""helpText"": null
  },
  {
    ""id"": 2488,
    ""name"": ""Neurofibromatosis Type 2"",
    ""description"": ""101000"",
    ""helpText"": null
  },
  {
    ""id"": 2489,
    ""name"": ""Neurogenic muscle weakness, Ataxia, Retinitis Pigmentosa  (NARP)"",
    ""description"": ""516060"",
    ""helpText"": null
  },
  {
    ""id"": 2490,
    ""name"": ""Niemann Pick Disease Type A"",
    ""description"": ""257200"",
    ""helpText"": null
  },
  {
    ""id"": 2491,
    ""name"": ""Niemann Pick Disease Type C "",
    ""description"": ""257220"",
    ""helpText"": null
  },
  {
    ""id"": 2926,
    ""name"": ""non-Herlitz Junctional Epidermolysis Bullosa "",
    ""description"": ""226650"",
    ""helpText"": null
  },
  {
    ""id"": 2492,
    ""name"": ""Non-Ketotic Hyperglycinaemia (NKH)/ Glycine Encephalopathy (GCE)"",
    ""description"": ""605899"",
    ""helpText"": null
  },
  {
    ""id"": 2570,
    ""name"": ""Noonan Syndrome"",
    ""description"": ""163950"",
    ""helpText"": null
  },
  {
    ""id"": 2650,
    ""name"": ""Norrie Disease"",
    ""description"": ""310600"",
    ""helpText"": null
  },
  {
    ""id"": 2493,
    ""name"": ""Oculocutaneous Albinism Type 1A"",
    ""description"": ""203100"",
    ""helpText"": null
  },
  {
    ""id"": 2494,
    ""name"": ""Oculocutaneous Albinism Type 1B"",
    ""description"": ""606952"",
    ""helpText"": null
  },
  {
    ""id"": 2715,
    ""name"": ""Omenn Syndrome"",
    ""description"": ""603554"",
    ""helpText"": null
  },
  {
    ""id"": 2891,
    ""name"": ""Optic Atrophy 1"",
    ""description"": ""165500"",
    ""helpText"": null
  },
  {
    ""id"": 2495,
    ""name"": ""Ornithine carbamoyltransferase Deficiency (OTC) "",
    ""description"": ""300461"",
    ""helpText"": null
  },
  {
    ""id"": 2496,
    ""name"": ""Ornithine transcarbamylase deficiency (OTD)"",
    ""description"": ""311250"",
    ""helpText"": null
  },
  {
    ""id"": 2499,
    ""name"": ""Osteogenesis Imperfecta type 1A"",
    ""description"": ""166240"",
    ""helpText"": null
  },
  {
    ""id"": 2497,
    ""name"": ""Osteogenesis Imperfecta Type II"",
    ""description"": ""120160"",
    ""helpText"": null
  },
  {
    ""id"": 2498,
    ""name"": ""Osteogenesis Imperfecta Type III"",
    ""description"": ""259420"",
    ""helpText"": null
  },
  {
    ""id"": 2864,
    ""name"": ""Osteogenesis Imperfecta type IV , type V , type VI"",
    ""description"": ""166220/610967/610968"",
    ""helpText"": null
  },
  {
    ""id"": 2917,
    ""name"": ""Osteogenesis Imperfecta Type VIII "",
    ""description"": ""610915"",
    ""helpText"": null
  },
  {
    ""id"": 2771,
    ""name"": ""Osteogenesis Imperfecta Type1 (OI1)"",
    ""description"": ""166200"",
    ""helpText"": null
  },
  {
    ""id"": 2769,
    ""name"": ""Osteopetrosis with Renal Tubular Acidosis (OPTB3)"",
    ""description"": ""259730"",
    ""helpText"": null
  },
  {
    ""id"": 2500,
    ""name"": ""Osteopetrosis, Autosomal Recessive 5 (OPTB5) and Osteopetrosis, Infantile Malignant 3"",
    ""description"": ""259720"",
    ""helpText"": null
  },
  {
    ""id"": 2501,
    ""name"": ""Ostheopathia Striata with Cranial Sclerosis (OSCS) "",
    ""description"": ""300373"",
    ""helpText"": null
  },
  {
    ""id"": 2502,
    ""name"": ""Otopalatodigital syndrome Type 2"",
    ""description"": ""304120"",
    ""helpText"": null
  },
  {
    ""id"": 2929,
    ""name"": ""Otopalatodigital type 1"",
    ""description"": ""311300"",
    ""helpText"": null
  },
  {
    ""id"": 2503,
    ""name"": ""Pachyonychia Congenita Type 1"",
    ""description"": ""167200"",
    ""helpText"": null
  },
  {
    ""id"": 2504,
    ""name"": ""Paragangliomas 4 (plg 4)"",
    ""description"": ""115310"",
    ""helpText"": null
  },
  {
    ""id"": 2950,
    ""name"": ""Parkinson’s disease 1 "",
    ""description"": ""168601"",
    ""helpText"": null
  },
  {
    ""id"": 2949,
    ""name"": ""Parkinson’s disease 4"",
    ""description"": ""605543"",
    ""helpText"": null
  },
  {
    ""id"": 2984,
    ""name"": ""Partial androgen insensitivity syndrome due to defects in the androgen receptor gene"",
    ""description"": ""312300"",
    ""helpText"": null
  },
  {
    ""id"": 2505,
    ""name"": ""Partial Lipodystrophy, Familial Type 2"",
    ""description"": ""151660"",
    ""helpText"": null
  },
  {
    ""id"": 2506,
    ""name"": ""Pelizaeus Merzbacher Disease "",
    ""description"": ""312080/311601"",
    ""helpText"": null
  },
  {
    ""id"": 2911,
    ""name"": ""Pendred Syndrome"",
    ""description"": ""274600"",
    ""helpText"": null
  },
  {
    ""id"": 2507,
    ""name"": ""Phenylketonuria (PKU)"",
    ""description"": ""261600"",
    ""helpText"": null
  },
  {
    ""id"": 2508,
    ""name"": ""Plakophilin 1 (PKP1) associated ectodermal dysplasia syndrome"",
    ""description"": ""601975"",
    ""helpText"": null
  },
  {
    ""id"": 2509,
    ""name"": ""Polycystic kidney disease "",
    ""description"": ""263200"",
    ""helpText"": null
  },
  {
    ""id"": 2860,
    ""name"": ""Pontocerebellar Hypoplasia type 1a, type 2a, type 2b, type 2c, type 2d , type 3, type 4, type 6 "",
    ""description"": ""607596 / 277470 / 612389 / 612390 / 613811 / 608027 / 225753 / 611523"",
    ""helpText"": null
  },
  {
    ""id"": 2843,
    ""name"": ""Pontocerebellar Hypoplasia type 1B (PCH1B)"",
    ""description"": ""614678"",
    ""helpText"": null
  },
  {
    ""id"": 2511,
    ""name"": ""Popliteal Pterigum Syndrome"",
    ""description"": ""119500"",
    ""helpText"": null
  },
  {
    ""id"": 2990,
    ""name"": ""Porencephaly 1"",
    ""description"": ""175780"",
    ""helpText"": null
  },
  {
    ""id"": 2512,
    ""name"": ""Prader Willi Syndrome "",
    ""description"": ""176270"",
    ""helpText"": null
  },
  {
    ""id"": 2598,
    ""name"": ""Progressive Familial Intrahepatic Cholestasis Type 1 (PFIC1)"",
    ""description"": ""211600"",
    ""helpText"": null
  },
  {
    ""id"": 2513,
    ""name"": ""Propionic Acidemia"",
    ""description"": ""606054"",
    ""helpText"": null
  },
  {
    ""id"": 2609,
    ""name"": ""Pseudoachondroplasia"",
    ""description"": ""177170"",
    ""helpText"": null
  },
  {
    ""id"": 2553,
    ""name"": ""Pseudohypoparathyroidism (PHP1a)"",
    ""description"": ""103581"",
    ""helpText"": null
  },
  {
    ""id"": 2514,
    ""name"": ""Pyrodoxine-dependent seizures"",
    ""description"": ""266100"",
    ""helpText"": null
  },
  {
    ""id"": 2953,
    ""name"": ""Pyruvate dehydrogenase E1-alpha deficiency X-linked"",
    ""description"": ""312170"",
    ""helpText"": null
  },
  {
    ""id"": 2515,
    ""name"": ""Pyruvate Dehydrogenase E1-beta Deficiency"",
    ""description"": ""179060"",
    ""helpText"": null
  },
  {
    ""id"": 2516,
    ""name"": ""Recessive Dystrophic Epidermolysis Bullosa* (Halleau-Siemens & Herlitz junctional)"",
    ""description"": ""various"",
    ""helpText"": null
  },
  {
    ""id"": 2517,
    ""name"": ""Recurrent Digynic Triploidy"",
    ""description"": null,
    ""helpText"": null
  },
  {
    ""id"": 2518,
    ""name"": ""Recurrent hydatitiform mole (HYDM1)"",
    ""description"": ""231090"",
    ""helpText"": null
  },
  {
    ""id"": 2610,
    ""name"": ""Renal Coloboma Syndrome"",
    ""description"": ""120330"",
    ""helpText"": null
  },
  {
    ""id"": 2898,
    ""name"": ""Renal Cysts and Diabetes (RCAD)"",
    ""description"": ""Renal Cysts and Diabetes (RCAD)"",
    ""helpText"": null
  },
  {
    ""id"": 2785,
    ""name"": ""Retinitis Pigmentosa (autosomal dominant) "",
    ""description"": ""180100"",
    ""helpText"": null
  },
  {
    ""id"": 2596,
    ""name"": ""Retinitis Pigmentosa (RP3) (x-linked)"",
    ""description"": ""300029"",
    ""helpText"": null
  },
  {
    ""id"": 2519,
    ""name"": ""Retinitis Pigmentosa (x-linked)"",
    ""description"": ""300455"",
    ""helpText"": null
  },
  {
    ""id"": 2914,
    ""name"": ""Retinitis Pigmentosa Type 11 (RP11)"",
    ""description"": ""600138"",
    ""helpText"": null
  },
  {
    ""id"": 2921,
    ""name"": ""Retinitis Pigmentosa type 7"",
    ""description"": ""608133"",
    ""helpText"": null
  },
  {
    ""id"": 2520,
    ""name"": ""Retinoblastoma"",
    ""description"": ""180200"",
    ""helpText"": null
  },
  {
    ""id"": 2521,
    ""name"": ""Retinoschisis (Juvenile)"",
    ""description"": ""312700"",
    ""helpText"": null
  },
  {
    ""id"": 2522,
    ""name"": ""Rett Syndrome (RTT) and Neonatal Encephalopathy"",
    ""description"": ""312750 / 300673"",
    ""helpText"": null
  },
  {
    ""id"": 2713,
    ""name"": ""Rhesus disease/ Haemolytic Disease of the Newborn (HDN)"",
    ""description"": """",
    ""helpText"": null
  },
  {
    ""id"": 2944,
    ""name"": ""Rigid spine muscular dystrophy  "",
    ""description"": ""602771"",
    ""helpText"": null
  },
  {
    ""id"": 2872,
    ""name"": ""Rothmund-Thomson Syndrome (RTS)"",
    ""description"": ""268400"",
    ""helpText"": null
  },
  {
    ""id"": 2608,
    ""name"": ""Saethre-Chotzen Syndrome (SCS)"",
    ""description"": ""101400"",
    ""helpText"": null
  },
  {
    ""id"": 2523,
    ""name"": ""Sandhoff Disease"",
    ""description"": ""268800"",
    ""helpText"": null
  },
  {
    ""id"": 2525,
    ""name"": ""Sanjad Sakati Syndrome (SLSN6)"",
    ""description"": ""241410"",
    ""helpText"": null
  },
  {
    ""id"": 2526,
    ""name"": ""Senior Loken Syndrome 6"",
    ""description"": ""610189"",
    ""helpText"": null
  },
  {
    ""id"": 2527,
    ""name"": ""Sensorineural deafness - autosomal recessive non-syndromic "",
    ""description"": ""220290"",
    ""helpText"": null
  },
  {
    ""id"": 2528,
    ""name"": ""Severe Combined Immune Deficiency (x-linked)"",
    ""description"": ""300400"",
    ""helpText"": null
  },
  {
    ""id"": 2613,
    ""name"": ""Severe Combined Immunodeficiency (SCID)"",
    ""description"": ""601457"",
    ""helpText"": null
  },
  {
    ""id"": 2886,
    ""name"": ""Severe Combined Immunodeficiency (SCID) (Adenosine Deaminase (ADA) deficient) "",
    ""description"": ""102700"",
    ""helpText"": null
  },
  {
    ""id"": 2600,
    ""name"": ""Severe Combined Immunodeficiency – autosomal recessive"",
    ""description"": ""600802"",
    ""helpText"": null
  },
  {
    ""id"": 2529,
    ""name"": ""Sickle Cell Anaemia* "",
    ""description"": ""603903"",
    ""helpText"": null
  },
  {
    ""id"": 2530,
    ""name"": ""Simpson Golabi Behmel Syndrome Type 1"",
    ""description"": ""312870 (to detect affected males)"",
    ""helpText"": null
  },
  {
    ""id"": 2531,
    ""name"": ""Smith Lemli Opitz Syndrome (SLO)"",
    ""description"": ""270400"",
    ""helpText"": null
  },
  {
    ""id"": 2896,
    ""name"": ""Sotos Syndrome"",
    ""description"": ""117550"",
    ""helpText"": null
  },
  {
    ""id"": 2532,
    ""name"": ""Spastic paraplegia"",
    ""description"": null,
    ""helpText"": null
  },
  {
    ""id"": 2533,
    ""name"": ""Spinal and Bulbar Muscular Atrophy X-linked (Kennedy disease) (in affected males embryos)"",
    ""description"": ""313200"",
    ""helpText"": null
  },
  {
    ""id"": 2534,
    ""name"": ""Spinal Muscular Atrophy (SMA1)"",
    ""description"": ""253300"",
    ""helpText"": null
  },
  {
    ""id"": 2535,
    ""name"": ""Spinal Muscular Atrophy and Respiratory Distress (SMARD1)"",
    ""description"": ""604320"",
    ""helpText"": null
  },
  {
    ""id"": 2942,
    ""name"": ""spinal muscular atrophy type 1 "",
    ""description"": ""253550"",
    ""helpText"": null
  },
  {
    ""id"": 2943,
    ""name"": ""spinal muscular atrophy type 2"",
    ""description"": ""253400"",
    ""helpText"": null
  },
  {
    ""id"": 2899,
    ""name"": ""Spinocerebellar Ataxia 7 (SCA 7)"",
    ""description"": ""164500"",
    ""helpText"": null
  },
  {
    ""id"": 2767,
    ""name"": ""Spinocerebellar Ataxia Type 1 (SCA1)"",
    ""description"": ""164400"",
    ""helpText"": null
  },
  {
    ""id"": 2961,
    ""name"": ""Spinocerebellar ataxia type 14"",
    ""description"": ""605361"",
    ""helpText"": null
  },
  {
    ""id"": 2789,
    ""name"": ""Spinocerebellar Ataxia Type 2 (SCA2)"",
    ""description"": ""183090"",
    ""helpText"": null
  },
  {
    ""id"": 2768,
    ""name"": ""Spinocerebellar Ataxia Type 3 (SCA 3) (Machado Joseph Disease)"",
    ""description"": ""109150"",
    ""helpText"": null
  },
  {
    ""id"": 2536,
    ""name"": ""Spinocerebellar Ataxia Type 6 (SCA6)"",
    ""description"": ""183086"",
    ""helpText"": null
  },
  {
    ""id"": 2973,
    ""name"": ""Spondyloepimetaphyseal dysplasia, Strudwick"",
    ""description"": ""184250"",
    ""helpText"": null
  },
  {
    ""id"": 2537,
    ""name"": ""Spondyloepiphyseal Dysplasia Congenita"",
    ""description"": ""183900"",
    ""helpText"": null
  },
  {
    ""id"": 2552,
    ""name"": ""Stickler Syndrome Type I, II, III and IV"",
    ""description"": ""108300/609508, 604841, 184840, 120210"",
    ""helpText"": null
  },
  {
    ""id"": 2538,
    ""name"": ""Stuve-Wiedemann Syndrome (Schwartz-Jampel Type 2 syndrome)"",
    ""description"": ""601559"",
    ""helpText"": null
  },
  {
    ""id"": 2539,
    ""name"": ""Succinic Semialdehyde Dehydrogenase Deficiency (SSADHD)"",
    ""description"": ""271980"",
    ""helpText"": null
  },
  {
    ""id"": 2790,
    ""name"": ""Surfactant Metabolism Dysfunction, Pulmonary 1 (SMDP1)"",
    ""description"": ""265120"",
    ""helpText"": null
  },
  {
    ""id"": 2923,
    ""name"": ""Surfactant Metabolism Dysfunction, Pulmonary, type 2"",
    ""description"": ""610913"",
    ""helpText"": null
  },
  {
    ""id"": 2540,
    ""name"": ""Tay Sachs Disease (infantile onset)"",
    ""description"": ""272800"",
    ""helpText"": null
  },
  {
    ""id"": 2560,
    ""name"": ""Townes-Brocks Syndrome "",
    ""description"": ""107480"",
    ""helpText"": null
  },
  {
    ""id"": 2542,
    ""name"": ""Treacher Collins Syndrome "",
    ""description"": ""154500"",
    ""helpText"": null
  },
  {
    ""id"": 2871,
    ""name"": ""Treacher Collins Syndrome Type 2 (TCS2)"",
    ""description"": ""613717"",
    ""helpText"": null
  },
  {
    ""id"": 2960,
    ""name"": ""Trichorhinophalangeal syndrome type 1"",
    ""description"": ""190350"",
    ""helpText"": null
  },
  {
    ""id"": 2918,
    ""name"": ""Trichothiodystrophy"",
    ""description"": ""601675"",
    ""helpText"": null
  },
  {
    ""id"": 2543,
    ""name"": ""Tuberous Sclerosis (TSC1 and TSC2)"",
    ""description"": ""191100, 613254"",
    ""helpText"": null
  },
  {
    ""id"": 2544,
    ""name"": ""Turner's syndrome (Mosaic)"",
    ""description"": null,
    ""helpText"": null
  },
  {
    ""id"": 2545,
    ""name"": ""Tyrosinaemia Type 1"",
    ""description"": ""276700"",
    ""helpText"": null
  },
  {
    ""id"": 2546,
    ""name"": ""Ullrich Congenital Muscular Dystrophy (UCMD) "",
    ""description"": ""254090"",
    ""helpText"": null
  },
  {
    ""id"": 2947,
    ""name"": ""Usher syndrome type 1 (including subtypes 1B, 1C, 1D, 1F, 1G, 1J)"",
    ""description"": ""276900 276904 601067 602083 606943 614869"",
    ""helpText"": null
  },
  {
    ""id"": 2948,
    ""name"": ""Usher syndrome type 2 (including subtypes 2A, 2C and 2D)"",
    ""description"": ""276901, 605472, 611383"",
    ""helpText"": null
  },
  {
    ""id"": 2547,
    ""name"": ""Von Hippel Lindau (VHL) Syndrome "",
    ""description"": ""193300"",
    ""helpText"": null
  },
  {
    ""id"": 2901,
    ""name"": ""Waardenburg Syndrome Type I"",
    ""description"": ""193500"",
    ""helpText"": null
  },
  {
    ""id"": 2902,
    ""name"": ""Waardenburg Syndrome Type IIa"",
    ""description"": ""193510"",
    ""helpText"": null
  },
  {
    ""id"": 2903,
    ""name"": ""Waardenburg Syndrome Type IId"",
    ""description"": ""608890"",
    ""helpText"": null
  },
  {
    ""id"": 2904,
    ""name"": ""Waardenburg Syndrome Type IIe"",
    ""description"": ""611584"",
    ""helpText"": null
  },
  {
    ""id"": 2905,
    ""name"": ""Waardenburg Syndrome Type III"",
    ""description"": ""148820"",
    ""helpText"": null
  },
  {
    ""id"": 2906,
    ""name"": ""Waardenburg Syndrome Type IVa"",
    ""description"": ""277580"",
    ""helpText"": null
  },
  {
    ""id"": 2907,
    ""name"": ""Waardenburg Syndrome Type IVb"",
    ""description"": ""613265"",
    ""helpText"": null
  },
  {
    ""id"": 2908,
    ""name"": ""Waardenburg Syndrome Type IVc"",
    ""description"": ""613266"",
    ""helpText"": null
  },
  {
    ""id"": 2548,
    ""name"": ""Wiscott-Aldrich Syndrome* "",
    ""description"": ""301000"",
    ""helpText"": null
  },
  {
    ""id"": 2724,
    ""name"": ""Wolcott-Rallison Syndrome"",
    ""description"": ""226980"",
    ""helpText"": null
  },
  {
    ""id"": 2549,
    ""name"": ""Wolman's Disease (Acid Lipase Deficiency)"",
    ""description"": ""278000"",
    ""helpText"": null
  },
  {
    ""id"": 2897,
    ""name"": ""X Linked Periventricular Heterotopia "",
    ""description"": ""300049"",
    ""helpText"": null
  },
  {
    ""id"": 2946,
    ""name"": ""X-linked lissencephaly "",
    ""description"": ""300067"",
    ""helpText"": null
  },
  {
    ""id"": 2625,
    ""name"": ""X-Linked Lymphoproliferative Disease Type 2 (XLP2) (Male Embryos Only)"",
    ""description"": ""300365"",
    ""helpText"": null
  },
  {
    ""id"": 2925,
    ""name"": ""X-Linked Opitz G / BBB Syndrome"",
    ""description"": ""300000"",
    ""helpText"": null
  },
  {
    ""id"": 2712,
    ""name"": ""X-Linked Thrombocytopenia (XLT)"",
    ""description"": ""313900"",
    ""helpText"": null
  }
]
";
    }
}
