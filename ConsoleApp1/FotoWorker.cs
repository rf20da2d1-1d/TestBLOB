using System;
using System.IO;
using TestBLOB.model;

namespace ConsoleApp1
{
    internal class FotoWorker
    {
        public FotoWorker()
        {
        }

        public void Start()
        {
            String path = @"M:\intpub\Billedsjov\";
            FileStream b1 = File.OpenRead(path + "solbær1.jpg");
            long b1size = b1.Length;
            byte[] billedBytes = new byte[b1size];
            int noOfBytes = b1.Read(billedBytes, 0, (int)b1size);

            FotodbContext db = new FotodbContext();
            Foto foto = new Foto();

            foto.Beskrivelse = "solbær billed";
            foto.FileType = "jpg";
            foto.Foto1 = billedBytes;
            db.Fotos.Add(foto);

            FileStream b2 = File.OpenRead(path + "solbær2.jpg");
            b1size = b2.Length;
            byte[] billedBytes2 = new byte[b1size];
            noOfBytes = b2.Read(billedBytes2, 0, (int)b1size);


            Foto foto2 = new Foto();
            foto2.Beskrivelse = "solbær billed #2";
            foto2.FileType = "jpg";
            foto2.Foto1 = billedBytes2;
            db.Fotos.Add(foto2);

            db.SaveChanges();
        }
    }
}