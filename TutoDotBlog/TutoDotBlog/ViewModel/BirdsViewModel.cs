using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoDotBlog.Model;

namespace TutoDotBlog.ViewModel
{
    public class BirdsViewModel
    {
        public ObservableCollection<Bird> BirdsList { get; private set; }

        public BirdsViewModel()
        {
            BirdsList = new ObservableCollection<Bird>
            {
                new Bird
                {
                    Name = "Rouge-Gorge",
                    LatinName = "Erithacus rubecula",
                    AverrageWeight = 18,
                    Description = @"Le rouge-gorge familier est une espèce de passereau. Classiquement placé dans la famille des Turdidae, 
                                    il figure actuellement, avec d'autres représentants de celle-ci, dans celle des Muscicapidae."
                },
                new Bird
                {
                    Name = "Mésange",
                    LatinName = "Parus major",
                    AverrageWeight = 16,
                    Description = @"La Mésange charbonnière est une espèce de passereaux de la famille des paridés. C'est la plus commune 
                                    des mésanges eurasiatiques."
                },
                new Bird
                {
                    Name = "Pigeon",
                    LatinName = "Columba",
                    AverrageWeight = 380,
                    Description = @"Les pigeons sont des oiseaux de la famille des Columbidae, vivant à l'origine dans les milieux 
                                    terrestres mais s'étant répandus, pour certaines espèces, en plaine et dans les villes, et se nourrissant "
                }
            };
        }


    }
}
