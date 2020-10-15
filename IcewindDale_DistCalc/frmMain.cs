using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcewindDale_DistCalc
{
    public partial class frmMain : Form
    {
        readonly double[,] dblRawDistance = new double[11, 11] {
            // Dougan's Hole (0), Good Mead (1), Intersection (2), Easthaven (3), 
            //    Caer-Dineval (4), Caer-Konig (5), Bryn Shander (6), Targos (7), 
            //    Bremen (8), Termalaine (9), Lonelywood (10)
            { 0, 4.3, 8.1, 13.1, 15.85, 20.35, 17.1, 20.1, 22.1, 29.7, 31.3 }, // Dougan's Hole (0)
            { 4.3, 0, 3.8, 8.8, 11.55, 16.05, 12.8, 15.8, 17.8, 25.4, 27}, // Good Mead (1)
            { 8.1, 3.8, 0, 5, 7.75, 12.25, 9, 12, 14, 21.6, 23.2}, // Intersection (2)
            { 13.1, 8.8, 5, 0, 12.75, 17.25, 14, 17, 19, 26.6, 28.2}, // Easthaven (3)
            { 15.85, 11.55, 7.75, 12.75, 0, 4.5, 16.75, 19.75, 21.75, 29.35, 30.95}, // Caer-Dineval (4)
            { 20.35, 16.05, 12.25, 17.25, 4.5, 0, 21.25, 24.25, 26.25, 33.85, 35.45}, // Caer-Konig (5)
            { 17.1, 12.8, 9, 14, 16.75, 21.25, 0, 3, 5, 12.6, 14.2}, // Bryn Shander (6)
            { 20.1, 15.8, 12, 17, 19.75, 24.25, 3, 0, 2, 9.6, 11.2}, // Targos (7)
            { 22.1, 17.8, 14, 19, 21.75, 26.25, 5, 2, 0, 11.6, 13.2}, // Bremen (8)
            { 29.7, 25.4, 21.6, 26.6, 29.35, 33.85, 12.6, 9.6, 11.6, 0, 1.6}, // Termalaine (9)
            { 31.3, 27, 23.2, 28.2, 30.95, 35.45, 14.2, 11.2, 13.2, 1.6, 0}, // Lonelywood (10)
         };

        readonly double[,,] milesPerHour = new double[3,6,3]
        {
            {
                // Tundra
                // 0 = slow pace, 1 = normal pace, 2 = fast pace
                { 1, 2, 4}, // Dogsled unrested
                { .5, 1, 2}, // Dogsled resting
                { 1, 2, 4}, // Axe Beak unrested
                { .5, 1, 2}, // Axe Beak resting
                { .25, .5, 1}, // Snowshoes
                { .125, .25, .5}, // Unaided
            },
            {
                // Road
                // 0 = slow pace, 1 = normal pace, 2 = fast pace
                { 6, 8, 12}, // Dogsled unrested
                { 3, 4, 6}, // Dogsled resting
                { 2, 4, 6}, // Axe Beak unrested
                { 1, 2, 3}, // Axe Beak resting
                { 1, 2, 3}, // Snowshoes
                { 1, 2, 3}, // Unaided
            },
            {
                // Mountain
                // 0 = slow pace, 1 = normal pace, 2 = fast pace
                { .5, 1, 2}, // Dogsled unrested
                { .25, .5, 1}, // Dogsled resting
                { .5, 1, 2}, // Axe Beak unrested
                { .25, .5, 1}, // Axe Beak resting
                { .125, .25, .5}, // Snowshoes
                { .0625, .125, .25}, // Unaided
            }
        };

        const int _dougansHole = 0;
        const int _goodMead = 1;
        const int _intersection = 2;
        const int _easthaven = 3;
        const int _caerDineval = 4;
        const int _caerKonig = 5;
        const int _brynShander = 6;
        const int _targos = 7;
        const int _bremen = 8;
        const int _termalaine = 9;
        const int _lonelywood = 10;

        const int _tundraSpeed = 0;
        const int _roadSpeed = 1;
        const int _mountainSpeed = 2;

        const int _slowPace = 0;
        const int _normalPace = 1;
        const int _fastPace = 2;

        const int _dogsledUnrested = 0;
        const int _dogsledResting = 1;
        const int _axeBeakUnrested = 2;
        const int _axeBeakResting = 3;
        const int _snowshoes = 4;
        const int _unaided = 5;

        const int _milesToFeetMod = 100;

        const int _dogsledExaustPerHour = 1;
        const int _axebeakExaustPerHour = 1;

        public frmMain()
        {
            InitializeComponent();
        }
    }
}
