using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Smartphone Nokia = new Nokia("938474574", "Lumia 550", "16432", 8);
Nokia.Ligar();
Nokia.InstalarAplicativo("Telegram");


Smartphone Iphone = new Iphone("935434564", "14 Pro Max", "3873564", 12);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Whatsapp");