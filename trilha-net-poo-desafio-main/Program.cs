using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("+55 (11)910096886", "Nokiaphone", "n212d0", 128);
n1.Ligar();
n1.InstalarAplicativo("WhatsApp");

Iphone i1 = new Iphone("+55 (11) 94002-8922", "Iphone X", "5451d", 100);
i1.InstalarAplicativo("Websupply");
i1.ReceberLigacao();