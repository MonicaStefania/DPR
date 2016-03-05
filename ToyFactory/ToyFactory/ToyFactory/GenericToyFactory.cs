using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Drawing;

namespace ToyFactory
{[Serializable]
    class GenericToyFactory:ISerializable
    {
        IFigure figure;
        public bool GameOver { get; set; }
        //Constructor for deserialization
        public GenericToyFactory()
        {
            this.GameOver = false;
        }
        public GenericToyFactory(SerializationInfo info, StreamingContext context)
        {
            this.figure = (IFigure)info.GetValue("figure", typeof(IFigure));
        }
        public static void SaveToFile(GenericToyFactory gtf, String path)
        {
            using (FileStream fl = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(fl, gtf);
            }
        }
        public static GenericToyFactory LoadFromFile(String path)
        {
            using (FileStream fl = new FileStream(path, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fl))
                {
                    BinaryFormatter binF = new BinaryFormatter();
                    return (GenericToyFactory)binF.Deserialize(fl);
                }
            }
        }
        public void run(IToys t, String name, string gender)
        {
            GameOver = false;
            if (gender == "girl")
            {
                 figure = t.createGirlFigure(name);
            }
            else figure = t.createBoyFigure(name);
        }
     
        public void stop()
        {
            GameOver = true;
            figure = null;
        }
        public void performAction(String type)
        {
            if(GameOver==false)
            {
                switch (type)
                {
                    case "jump":
                        figure.jump();
                        break;
                    case "cry":
                        figure.cry();
                        break;
                    case "talk":
                        figure.talk();
                        break;
                    case "play":
                        figure.play();
                        break;
                    case "sleep":
                        figure.sleep();
                        break;
                    case "eat":
                        figure.eat();
                        break;
                            
                            }
                
            }
        }
        public Image avatar()
        {
            return this.figure.getAvatar();
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("figure", figure);
        }
    }
}
