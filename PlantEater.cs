using System;

namespace Animals
{
    public class PlantEater : Animal
    {

        AnimalsApp animals;
        private bool lionClose = false;

        public PlantEater() : base(){

        }

        public PlantEater(int health, int hunger, int speed, int damage, int reproductionRate, int x, int y, AnimalsApp animals){
            this.health = health;
            this.hunger = hunger;
            this.speed = speed;
            this.damage = damage;
            this.reproductionRate = reproductionRate;
            this.x = x;
            this.y = y;
            this.animals = animals;
        }

        public void move(){

        }

        public void update(){
            isLionClose();
            move();
        }

        public bool isLionClose(){
            int distance;
            int x = Math.Abs(this.x - animals.getLion().x);
            int y = Math.Abs(this.y - animals.getLion().y);

            distance = (int) Math.Sqrt((x * x) + (y * y));

            if(distance < 35){
                lionClose = true;
            }else{
                lionClose = false;
            }

            return lionClose;
        }

        public double directionToLion(){

        }
    }
}