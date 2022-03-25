using Demo.SivitCare.Selenium.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.SivitCare.PageObject
{

    public class HemsireIslemleriPage : BasePage
    {
        public HemsireIslemleriPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Basi Yarası Ekleme
        /// </summary>
        public IWebElement btn_BasiYarasi => FindElementByXPath("//i[contains(@class,'basi')]");
        public IWebElement btn_BasiYarasiEkle => FindElementByXPath("(//MAT-ICON[@role='img'][text()='add_circle_outline'])[1]"); 
        public IWebElement olusmaYeridropdown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-basi-yarasi-dialog/div[1]/mat-form-field[1]/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement txt_Evde => FindElementByXPath("//span[contains(text(),'Hastanede')]");
        public IWebElement bolgeDropDown=> FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-basi-yarasi-dialog/div[1]/mat-form-field[2]/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement txt_Dirsekler => FindElementByXPath("//span[contains(text(),'Dirsekler')]");
        public IWebElement txt_Boyutu => FindElementByXPath("//input[@data-placeholder='Boyutu']");
        public IWebElement txt_Acıklama => FindElementByXPath("//input[@data-placeholder='Açıklama']");
        public IWebElement evreDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-basi-yarasi-dialog/div[1]/mat-form-field[3]/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement txt_DerinDoku => FindElementByXPath("//span[contains(text(),'Derin')]");      
        public IWebElement btn_BasiYarasiKyadet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement validateRandomBoyut => FindElementByXPath("//P[@class='p-over'][text()=' Boyut : " + randomBoyut + " ']");
        public IWebElement fotoSec => FindElementByXPath("(//IMG[@class='inner-image'])[1]");
        public IWebElement btn_yaraBakimiEkle => FindElementByXPath("(//MAT-ICON[@role='img'][text()='add_circle_outline'])[2]");
        public IWebElement sonucDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-yarabakim-dialog/div[1]/mat-form-field[1]/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement txt_Kismen => FindElementByXPath("//span[contains(text(),'Kısmen İyileşti')]");
        public IWebElement degerlendirmeDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-yarabakim-dialog/div[1]/mat-form-field[2]/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement txt_hastaTekrar => FindElementByXPath("//span[contains(text(),'Tekrar Değerlendir')]");
        public IWebElement txt_Genislik => FindElementByXPath("//input[@data-placeholder='Genişlik']");
        public IWebElement txt_Uzunluk => FindElementByXPath("//input[@data-placeholder='Uzunluk']");
        public IWebElement btn_YaraTakibiKaydet => FindElementByXPath("//span[text()=' Kaydet ']");
        public IWebElement validateSonuc => FindElementByXPath("//TD[text()='Kısmen İyileşti']");
        public IWebElement silBasiYarasi => FindElementByXPath("(//MAT-ICON[@role='img'][text()='delete'])[1]");

        


        /// <summary>
        /// invaziv Girisimler Ekleme
        /// </summary>
        public IWebElement btn_InvazivGirisimler => FindElementByXPath("//i[contains(@class,'invaziv')]");
        public IWebElement btn_InvazivEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[1]/div/div/button[1]");
        public IWebElement txt_TupNo => FindElementByXPath("//input[@data-placeholder='Tüp No']");
        public IWebElement invaziGirisimDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-invasiv-dialog/div[3]/mat-form-field/div/div[1]/div/mat-select");
        public IWebElement txt_Peg => FindElementByXPath("//span[contains(text(),'Peg')]");
        public IWebElement btn_InvaziKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement validateTarih => FindElementByXPath("//div[contains(text(),'Şu anda')]");
        public IWebElement validateTupNo => FindElementByXPath("//div[contains(text(),'1258')]"); 
        public IWebElement validateInvaziGiris => FindElementByXPath("//div[contains(text(),'Peg')]");
       
        /// <summary>
        /// Invaziv Düzenle/Sil/Cikar
        /// </summary>
        public IWebElement btn_InvazivDuzenle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[2]/table/tbody/mat-row[1]/mat-cell[1]/div/button[1]");
        public IWebElement txt_FoleySonda => FindElementByXPath("//span[contains(text(),'Foley Sonda')]");
        public IWebElement validateTupNoDuzenle => FindElementByXPath("//div[contains(text(),'1259')]");
        public IWebElement validateInvaziGirisimDuzenle => FindElementByXPath("//div[contains(text(),' Foley Sonda ')]");
        public IWebElement btn_InvazivSil => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[2]/table/tbody/mat-row/mat-cell[1]/div/button[2]");
        
        public IWebElement btn_InvaziveCikar => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[2]/table/tbody/mat-row[1]/mat-cell[5]/div[1]/button");
        public IWebElement btn_InvaziveCikarKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");

        /// <summary>
        /// Agri Takibi Ekle/Duzenle/Sil
        /// </summary>
        public IWebElement btn_AgriTakibi => FindElementByXPath("//i[contains(@class,'agri')]");
        public IWebElement btn_AgriEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-agri-takip/div[1]/div/div/button[1]");
        public IWebElement btn_YuzSkalasi => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-agri-dialog/div[1]/mat-button-toggle-group/mat-button-toggle[3]/button");
        public IWebElement btn_AgriDurumu => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-agri-dialog/div[2]/mat-button-toggle-group/mat-button-toggle[3]/button");
        public IWebElement btn_PupilSkalasi => FindElementByXPath("//span[text()='6']");
        public IWebElement btn_AgriTakibiKaydet => FindElementByXPath("//span[text()=' Kaydet ']");
        public IWebElement validatePupilSkalasi => FindElementByXPath("//div[text()=' 6 ']");
        public IWebElement btn_AgriTakibiSil => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-agri-takip/div[2]/table/tbody/mat-row[2]/mat-cell[1]/div/button[2]");
        

        /// <summary>
        /// Hemşire Değerlendirme Ekle/Düzenle/Sil
        /// </summary>
        public IWebElement btn_HemsireDegerlendirme => FindElementByXPath("//i[contains(@class,'degerlendirme')]");
        public IWebElement btn_HemsireDegerlendirmeEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-hemsire-degerlendirme/div[1]/div/div/button[1]");
        public IWebElement txt_areaDegerlendirmeNotu => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-degerlendirme-dialog/div[2]/mat-form-field/div/div[1]/div/textarea");
        public IWebElement btn_HemsireDegerlendirmeKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement validateHemsireDegerlendir => FindElementByXPath("//div[contains(text(),'Hasta Uyuyor')]");
        public IWebElement btn_HemsireDegerlendirmeDuzenle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-hemsire-degerlendirme/div[2]/table/tbody/mat-row[1]/mat-cell[1]/div/button[1]");
        public IWebElement validateHemsireDegerlendirafterDuzenle => FindElementByXPath("//div[contains(text(),'Hasta Kalktı')]");
        public IWebElement btn_HemsireDegerlendirmeSil => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-hemsire-degerlendirme/div[2]/table/tbody/mat-row[1]/mat-cell[1]/div/button[2]");

        /// <summary>
        /// Cilt Tanımlama Ekle/Düzenle/Sil
        /// </summary>
        public IWebElement btn_CiltTanimlama => FindElementByXPath("//i[contains(@class,'cilt')]");
        public IWebElement btn_CiltTanimlamaEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-cilt-tanilama/div[1]/div/div/button[1]");
        public IWebElement txt_Diger => FindElementByXPath("(//SPAN[@class='mat-radio-label-content'])[1]/..//SPAN[@class='mat-radio-outer-circle']");
        public IWebElement txt_DeriAcilmis => FindElementByXPath("(//SPAN[@class='mat-radio-label-content'])[11]/..//SPAN[@class='mat-radio-outer-circle']");
        public IWebElement btn_CiltTanimlamaKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement validateAgriSkalasi => FindElementByXPath("//div[contains(text(),' Deri Açılmış ')]");

        /// <summary>
        /// Hasta İzalasyonu Ekle/Düzenle/sil/dogrula
        /// </summary>
        public IWebElement btn_HastaIzolastonu => FindElementByXPath("//i[@class='hastaizolasyon']");
        public IWebElement btn_HastaIzolastonuEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-itaki/div[1]/div/div/button[1]");
        public IWebElement btn_Yok => FindElementByXPath("(//DIV[@class='col-sm-12'])[3]//SPAN[@class='mat-button-toggle-label-content'][text()=' Yok ']");
        public IWebElement btn_HastaIzolasyonKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement btn_HastaIzolasyonDuzenle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-itaki/div[2]/table/tbody/mat-row[1]/mat-cell[1]/div/button[1]");
        public IWebElement btn_HastaIzolasyonVar => FindElementByXPath("(//DIV[@class='col-sm-12'])[3]//SPAN[@class='mat-button-toggle-label-content'][text()=' Var ']");
        public IWebElement chkboxSolunum => FindElementByXPath("((//DIV[@class='col-sm-6'])[1]//SPAN[@class='mat-checkbox-inner-container'])[2]");
        public IWebElement chkboxDiger => FindElementByXPath("((//DIV[@class='col-sm-6'])[1]//SPAN[@class='mat-checkbox-inner-container'])[4]");
        public IWebElement txt_areaAciklama => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-izolasyon-dialog/div[2]/div[2]/mat-form-field/div/div[1]/div/textarea");
        public IWebElement btn_HastaIzolastonuSil => FindElementByXPath("(//MAT-CELL[@role='gridcell'])[1]//MAT-ICON[@role='img'][text()='delete']");
        public IWebElement validateIzalasyonIhtiyaciYok => FindElementByXPath("(//MAT-CELL[@role='gridcell'])[5]//DIV[@class='ng-star-inserted'][text()=' Yok ']");
        public IWebElement validateIzalasyonIhtiyaciVar => FindElementByXPath("(//MAT-CELL[@role='gridcell'])[5]//DIV[@class='ng-star-inserted'][text()=' Var ']");

        /// <summary>
        /// Hasta Nifrisyonu
        /// </summary>
        public IWebElement btn_HastaNutrisyon => FindElementByXPath("//i[@class='hastabeslenme']");
        public IWebElement btn_HastaNutrisyonEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-nutrition/div[1]/div/div/button[1]/span[1]/mat-icon");
        public IWebElement dropdown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-nutrition-dialog/div[1]/mat-form-field/div/div[1]/div/mat-select/div/div[2]");
        public IWebElement btn_BeslenmeSekliKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement lblOral => FindElementByXPath("//SPAN[@class='mat-option-text'][text()='Oral']");
        public IWebElement validateBeslenmeKodu => FindElementByXPath("//DIV[@class='ng-star-inserted'][text()=' Oral ']");

        /// <summary>
        /// Hasta Kısıtlama
        /// </summary>       
        public IWebElement btn_HareketKisitlama => FindElementByXPath("//i[@class='kisitlama']");
        public IWebElement btn_HareketKisitlamaEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-hasta-kisitlama/div[1]/div/div/button[1]");
        public IWebElement  cb_SedatifIlacUygulama=> FindElementByXPath("(//SPAN[@class='mat-checkbox-inner-container'])[4]");
        public IWebElement cb_VentilatorAyrilma => FindElementByXPath("(//SPAN[@class='mat-checkbox-inner-container'])[9]");
        public IWebElement cb_SolAltExtremite => FindElementByXPath("(//SPAN[@class='mat-checkbox-inner-container'])[14]");
        public IWebElement btn_HareketKisitlamaKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement validateAlinanOnlemler => FindElementByXPath("//div[text() =' Sedatif İlaç Uygulama ']");
        public IWebElement validateKisitlamaNedenleri => FindElementByXPath("//div[text() =' Ventilatörden Ayrılma ']");
        public IWebElement btn_Kaldir => FindElementByXPath("(//MAT-ICON[@role='img'][text()='power_off'])[1]");
        public IWebElement cb_KisitlamadanDolayi => FindElementByXPath("(//SPAN[@class='mat-checkbox-inner-container'])[4]");
        public IWebElement btn_KisitlamaKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        public IWebElement validateKisitlamaKaldirmaKriteri => FindElementByXPath("//div[text() =' Kısıtlamadan Dolayı Zarar Oluştu ']");


        public void HareketKisitlama()
        {
            Thread.Sleep(1000);
            btn_HareketKisitlama.Click();           
            btn_HareketKisitlamaEkle.Click();
            cb_SedatifIlacUygulama.Click();
            cb_VentilatorAyrilma.Click();
            cb_SolAltExtremite.Click();
            btn_HareketKisitlamaKaydet.Click();
            ValidateElementExist(validateAlinanOnlemler, "Sedatif İlaç Uygulama");
            ValidateElementExist(validateKisitlamaNedenleri, "Ventilatörden Ayrılma");
            btn_Kaldir.Click();
            cb_KisitlamadanDolayi.Click();
            btn_KisitlamaKaydet.Click(); ;
            ValidateElementExist(validateKisitlamaKaldirmaKriteri, "Kısıtlamadan Dolayı Zarar Oluştu");
            Sil();
            ValidateElementNotExist("Kısıtlamadan Dolayı Zarar Oluştu", "//div[text() =' Ventilatörden Ayrılma ']");
        }


        public static int randomnum1 = RandomNumber.GetRandom();
        string randomBoyut = randomnum1.ToString();
        public void basiYarasiEkle()
        {
            Thread.Sleep(2000);
            btn_BasiYarasi.Click();
            btn_BasiYarasiEkle.Click();
            olusmaYeridropdown.Click();
            txt_Evde.Click();
            bolgeDropDown.Click();
            txt_Dirsekler.Click();
            sendKeys(txt_Boyutu, randomBoyut);
            evreDropDown.Click();
            txt_DerinDoku.Click();
            sendKeys(txt_Acıklama, "Büyük Bir Yara");
            btn_BasiYarasiKyadet.Click();
            ValidateElementExist(validateRandomBoyut, "Boyut : " + randomBoyut + "");
            fotoSec.Click();
            btn_yaraBakimiEkle.Click();
            sonucDropDown.Click();
            txt_Kismen.Click();
            degerlendirmeDropDown.Click();
            txt_hastaTekrar.Click();
            sendKeys(txt_Genislik, "2");
            sendKeys(txt_Uzunluk, "3");
            sendKeys(txt_Acıklama, "Deneme");
            btn_YaraTakibiKaydet.Click();
            ValidateElementExist(validateSonuc, "Kısmen İyileşti");
            Sil();
            ValidateElementNotExist("Boyut", "//P[@class='p-over'][text()=' Boyut : " + randomBoyut + " ']");
            ValidateElementNotExist("Sonuc from Table", "//TD[text()='Kısmen İyileşti']");
        }

        public void InvazivGirisimEkle() 
        {
            Thread.Sleep(2000);
            btn_HemsireDegerlendirme.Click();
            btn_InvazivGirisimler.Click();
            btn_InvazivEkle.Click();
            sendKeys(txt_TupNo, "1258");
            Thread.Sleep(500);
            invaziGirisimDropDown.Click();
            txt_Peg.Click();
            btn_InvaziKaydet.Click();
            ValidateElementExist(validateTarih, "Şu anda");
            ValidateElementExist(validateTupNo, "1258");
            ValidateElementExist(validateInvaziGiris, "Peg");           
        }
        public void InvazivDuzenle()
        {
            btn_InvazivDuzenle.Click();           
            sendKeys(txt_TupNo, "1259");
            invaziGirisimDropDown.Click();
            Thread.Sleep(500);
            txt_FoleySonda.Click();
            btn_InvaziKaydet.Click();
            ValidateElementExist(validateTupNoDuzenle, "1259");
            ValidateElementExist(validateInvaziGirisimDuzenle, "Foley Sonda");
        }
        public void InvazivCikar()
        {
            Thread.Sleep(1000);
            btn_InvaziveCikar.Click();
            btn_InvaziveCikarKaydet.Click();
        }
        public void InvazivSil()
        {
            Sil();
            ValidateElementNotExist("Tüp No", "//div[contains(text(),'1259')]");
        }        

        public void AgriTakibiEkleSil() 
        {
            Thread.Sleep(1000);
            btn_AgriTakibi.Click();
            btn_AgriEkle.Click();
            btn_YuzSkalasi.Click();
            btn_AgriDurumu.Click();
            btn_PupilSkalasi.Click();
            btn_AgriTakibiKaydet.Click();
            ValidateElementExist(validatePupilSkalasi, "6");
            Sil();
            ValidateElementNotExist("Pupil Skalasi", "//div[text()=' 6 ']");
            Thread.Sleep(2000);            
        }
        public void HemsireDegerlendirmeEkleDuzenleSil() 
        {
            Thread.Sleep(2000);
            btn_HemsireDegerlendirme.Click();
            btn_HemsireDegerlendirmeEkle.Click();
            sendKeys(txt_areaDegerlendirmeNotu, "Hasta Uyuyor");
            btn_HemsireDegerlendirmeKaydet.Click();
            ValidateElementExist(validateHemsireDegerlendir, "Hasta Uyuyor");
            btn_HemsireDegerlendirmeDuzenle.Click();
            sendKeys(txt_areaDegerlendirmeNotu, "Hasta Kalktı");
            btn_HemsireDegerlendirmeKaydet.Click();
            ValidateElementExist(validateHemsireDegerlendirafterDuzenle, "Hasta Kalktı");
            Thread.Sleep(1000);
            Sil();
            ValidateElementNotExist("Değerlendirme", "//div[contains(text(),'Hasta Kalktı')]");
        }
        public void CiltTanimlama() 
        {
            Thread.Sleep(1000);
            btn_CiltTanimlama.Click();
            btn_CiltTanimlamaEkle.Click();
            Thread.Sleep(500);
            txt_Diger.Click();
            txt_DeriAcilmis.Click();
            btn_CiltTanimlamaKaydet.Click();
            ValidateElementExist(validateAgriSkalasi, "Deri Açılmış");
            Sil();
            ValidateElementNotExist("Agri Skalasi", "//div[contains(text(),' Deri Açılmış ')]");
        }
        
        public void HastaIzalasyonu() 
        {
            Thread.Sleep(1000);
            btn_HastaIzolastonu.Click();
            btn_HastaIzolastonuEkle.Click();
            btn_Yok.Click();
            btn_HastaIzolasyonKaydet.Click();
            Thread.Sleep(1000);
            ValidateElementExist(validateIzalasyonIhtiyaciYok,"Yok");
            btn_HastaIzolasyonDuzenle.Click();
            Thread.Sleep(1000);
            btn_HastaIzolasyonVar.Click();            
           // chkboxSolunum.Click();
           // chkboxDiger.Click();
           // sendKeys(txt_areaAciklama, "Yapılmadı");
            btn_HastaIzolasyonKaydet.Click();
            ValidateElementExist(validateIzalasyonIhtiyaciVar, "Var");
            Sil();
            ValidateElementNotExist("İzolasyon İhtiyacı", "(//MAT-CELL[@role='gridcell'])[5]//DIV[@class='ng-star-inserted'][text()=' Var ']");
        }


        public void HastaNutrisyon () 
        {
            Thread.Sleep(1000);
            btn_HastaNutrisyon.Click();
            btn_HastaNutrisyonEkle.Click();
            dropdown.Click();
            lblOral.Click();
            btn_BeslenmeSekliKaydet.Click();
            ValidateElementExist(validateBeslenmeKodu,"Oral");
            Sil();
            ValidateElementNotExist("Oral", "//DIV[@class='ng-star-inserted'][text()=' Oral ']");
        }

       
    }    
}
