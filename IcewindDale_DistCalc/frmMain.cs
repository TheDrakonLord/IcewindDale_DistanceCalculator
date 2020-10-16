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
        /// <summary>
        /// raw distance table
        /// </summary>
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

        /// <summary>
        /// table of speeds
        /// </summary>
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

        // Constants for reffering to raw distance table
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

        // Constants for reffering to the first dimension of the speed table
        const int _tundraSpeed = 0;
        const int _roadSpeed = 1;
        const int _mountainSpeed = 2;

        // Constants for reffering to the second dimension of the speed table
        const int _slowPace = 0;
        const int _normalPace = 1;
        const int _fastPace = 2;

        // Constants for reffering to the third dimension of the speed table
        const int _dogsledUnrested = 0;
        const int _dogsledResting = 1;
        const int _axeBeakUnrested = 2;
        const int _axeBeakResting = 3;
        const int _snowshoes = 4;
        const int _unaided = 5;

        // Modifier to be applied when converting speeds from miles to feed
        const int _milesToFeetMod = 100;

        // The number of levels of exhaustion each form of travel gains per hour
        const int _dogsledExaustPerHour = 1;
        const int _axebeakExaustPerHour = 1;
        const int _playerExaustPerHour = 1;

        // Thresholds and penalities for exceeding certain levels of exhaustion
        const int _exhaustHalfSpeedThreshold = 2;
        const double _exhaustHalfSpeedPenalty = .5;
        const int _exhaustStopThreshold = 3;
        const int _exhaustStopPenalty = 0;

        // User selection variables
        int _terrain = 0;
        int _method = 0;
        int _pace = 1;
        bool _resting = true;
        bool _undead = false;
        bool _playerExhausted = false;
        bool _scaleMiles = true;
        int _origin = 0;
        int _destination = 0;
        bool _otherDistance = false;
        double _otherTotalDistance = 0;

        // result variables
        double _totalDays = 0;
        double _totalHours = 0;
        double _totalMinutes = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        // Functions and Methods

        private void calculateDistance()
        {
            txtDays.Clear();
            txtHours.Clear();
            txtMinutes.Clear();
            txtUntraveled.Clear();
            double rawDistance = 0;
            double speed = 0;
            double rawTime = 0;
            if (_otherDistance)
            {
                rawDistance = _otherTotalDistance;
                speed = milesPerHour[_terrain, _method, _pace];
                if (_playerExhausted && (_method == _unaided || _method == _snowshoes))
                {
                    speed *= _exhaustHalfSpeedPenalty;
                }
                rawTime = 0;
                if (_resting || _undead || _method == _snowshoes || _method == _unaided)
                {
                    rawTime = rawDistance / speed;
                    _totalDays = Math.Floor(rawTime / 8);
                    rawTime -= _totalDays * 8;
                    _totalHours = Math.Floor(rawTime);
                    rawTime -= _totalHours;
                    _totalMinutes = rawTime * 60;
                    _totalMinutes = Math.Round(_totalMinutes);                    
                }
                else
                {
                    double unhinderedDistance = speed * _exhaustHalfSpeedThreshold;
                    rawDistance -= unhinderedDistance;
                    if (rawDistance < 0)
                    {
                        rawTime = unhinderedDistance / speed;
                        _totalDays = Math.Floor(rawTime / 8);
                        rawTime -= _totalDays * 8;
                        _totalHours = Math.Floor(rawTime);
                        rawTime -= _totalHours;
                        _totalMinutes = rawTime * 60;
                        _totalMinutes = Math.Round(_totalMinutes);
                    }
                    else
                    {
                        speed *= _exhaustHalfSpeedPenalty;
                        double halfDistance = speed * _exhaustHalfSpeedThreshold;
                        rawDistance -= halfDistance;
                        if(rawDistance < 0)
                        {
                            rawTime = (halfDistance / speed) + 2;
                            _totalDays = Math.Floor(rawTime / 8);
                            rawTime -= _totalDays * 8;
                            _totalHours = Math.Floor(rawTime);
                            rawTime -= _totalHours;
                            _totalMinutes = rawTime * 60;
                            _totalMinutes = Math.Round(_totalMinutes);
                        }
                        else
                        {
                            txtUntraveled.ForeColor = Color.Red;
                            txtUntraveled.Text = rawDistance.ToString();
                            _totalDays = 0;
                            _totalHours = 5;
                            _totalMinutes = 0;
                        }
                        speed *= _exhaustStopPenalty;
                    }                    
                }
            }
            else
            {
                rawDistance = dblRawDistance[_origin, _destination];
                speed = milesPerHour[_terrain, _method, _pace];
                if (_playerExhausted && (_method == _unaided || _method == _snowshoes))
                {
                    speed *= _exhaustHalfSpeedPenalty;
                }
                rawTime = 0;
                if (_resting || _undead || _method == _snowshoes || _method == _unaided)
                {
                    rawTime = rawDistance / speed;
                    _totalDays = Math.Floor(rawTime / 8);
                    rawTime -= _totalDays * 8;
                    _totalHours = Math.Floor(rawTime);
                    rawTime -= _totalHours;
                    _totalMinutes = rawTime * 60;
                    _totalMinutes = Math.Round(_totalMinutes);
                }
                else
                {
                    double unhinderedDistance = speed * _exhaustHalfSpeedThreshold;
                    rawDistance -= unhinderedDistance;
                    if (rawDistance < 0)
                    {
                        rawTime = unhinderedDistance / speed;
                        _totalDays = Math.Floor(rawTime / 8);
                        rawTime -= _totalDays * 8;
                        _totalHours = Math.Floor(rawTime);
                        rawTime -= _totalHours;
                        _totalMinutes = rawTime * 60;
                        _totalMinutes = Math.Round(_totalMinutes);
                    }
                    else
                    {
                        speed *= _exhaustHalfSpeedPenalty;
                        double halfDistance = speed * _exhaustHalfSpeedThreshold;
                        rawDistance -= halfDistance;
                        if (rawDistance < 0)
                        {
                            rawTime = (halfDistance / speed) + 2;
                            _totalDays = Math.Floor(rawTime / 8);
                            rawTime -= _totalDays * 8;
                            _totalHours = Math.Floor(rawTime);
                            rawTime -= _totalHours;
                            _totalMinutes = rawTime * 60;
                            _totalMinutes = Math.Round(_totalMinutes);
                        }
                        else
                        {
                            txtUntraveled.ForeColor = Color.Red;
                            txtUntraveled.Text = rawDistance.ToString();
                            _totalDays = 0;
                            _totalHours = 5;
                            _totalMinutes = 0;
                        }
                        speed *= _exhaustStopPenalty;
                    }
                }
            }

            txtDays.Text = _totalDays.ToString();
            txtHours.Text = _totalHours.ToString();
            txtMinutes.Text = _totalMinutes.ToString();
        }

        // Form control event handlers
        private void frmMain_Load(object sender, EventArgs e)
        {
            radTundra.Checked = true;
            radDogsled.Checked = true;
            radResting.Checked = true;
            radLiving.Checked = true;
            radPlayerHealthy.Checked = true;
            radOriginDougansHole.Checked = true;
            radDestDougansHole.Checked = true;
            radNormal.Checked = true;
            txtOtherDistance.Enabled = false;
            calculateDistance();
        }

        private void radTundra_CheckedChanged(object sender, EventArgs e)
        {
            _terrain = _tundraSpeed;
            calculateDistance();
        }

        private void radRoad_CheckedChanged(object sender, EventArgs e)
        {
            _terrain = _roadSpeed;
            calculateDistance();
        }

        private void radMountain_CheckedChanged(object sender, EventArgs e)
        {
            _terrain = _mountainSpeed;
            calculateDistance();
        }

        private void radDogsled_CheckedChanged(object sender, EventArgs e)
        {
            if (radResting.Checked == true)
            {
                _method = _dogsledResting;
            }
            else
            {
                _method = _dogsledUnrested;
            }
            calculateDistance();
        }

        private void radAxeBeak_CheckedChanged(object sender, EventArgs e)
        {
            if (radResting.Checked == true)
            {
                _method = _axeBeakResting;
            }
            else
            {
                _method = _axeBeakUnrested;
            }
            calculateDistance();
        }

        private void radSnowshoes_CheckedChanged(object sender, EventArgs e)
        {
            _method = _snowshoes;
            calculateDistance();
        }

        private void radUnaided_CheckedChanged(object sender, EventArgs e)
        {
            _method = _unaided;
            calculateDistance();
        }

        private void radResting_CheckedChanged(object sender, EventArgs e)
        {
            _resting = true;
            calculateDistance();
        }

        private void radUnrested_CheckedChanged(object sender, EventArgs e)
        {
            _resting = false;
            calculateDistance();
        }

        private void radMiles_CheckedChanged(object sender, EventArgs e)
        {
            _scaleMiles = true;
            calculateDistance();
        }

        private void radFeet_CheckedChanged(object sender, EventArgs e)
        {
            _scaleMiles = false;
            calculateDistance();
        }

        private void radOriginDougansHole_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _dougansHole;
            calculateDistance();
        }

        private void radOriginGoodMead_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _goodMead;
            calculateDistance();
        }

        private void radOriginIntersection_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _intersection;
            calculateDistance();
        }

        private void radOriginEasthaven_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _easthaven;
            calculateDistance();
        }

        private void radOriginCaerDineval_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _caerDineval;
            calculateDistance();
        }

        private void radOriginCaerKonig_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _caerKonig;
            calculateDistance();
        }

        private void radOriginBrynShander_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _brynShander;
            calculateDistance();
        }

        private void radOriginTargos_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _targos;
            calculateDistance();
        }

        private void radOriginBremen_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _bremen;
            calculateDistance();
        }

        private void radOriginTermalaine_CheckedChanged(object sender, EventArgs e)
        {
            if (radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _termalaine;
            calculateDistance();
        }

        private void radOriginLonelywood_CheckedChanged(object sender, EventArgs e)
        {
            if ( radDestOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _origin = _lonelywood;
            calculateDistance();
        }

        private void radOriginOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherDistance.Enabled = true;
            _otherDistance = true;
            txtOtherDistance.Clear();
            calculateDistance();
        }

        private void radDestDougansHole_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _dougansHole;
            calculateDistance();
        }

        private void radDestGoodMead_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _goodMead;
            calculateDistance();
        }

        private void radDestIntersection_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _intersection;
            calculateDistance();
        }

        private void radDestEasthaven_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _easthaven;
            calculateDistance();
        }

        private void radDestCaerDineval_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _caerDineval;
            calculateDistance();
        }

        private void radDestCaerKonig_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _caerKonig;
            calculateDistance();
        }

        private void radDestBrynShander_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _brynShander;
            calculateDistance();
        }

        private void radDestTargos_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _targos;
            calculateDistance();
        }

        private void radDestBremen_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _bremen;
            calculateDistance();
        }

        private void radDestTermalaine_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _termalaine;
            calculateDistance();
        }

        private void radDestLonelywood_CheckedChanged(object sender, EventArgs e)
        {
            if (radOriginOther.Checked == false)
            {
                txtOtherDistance.Enabled = false;
                _otherDistance = false;
                txtOtherDistance.Clear();
            }

            _destination = _lonelywood;
            calculateDistance();
        }

        private void radDestOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherDistance.Enabled = true;
            _otherDistance = true;
            txtOtherDistance.Clear();
            calculateDistance();
        }

        private void txtOtherDistance_TextChanged(object sender, EventArgs e)
        {
            if (txtOtherDistance.Text != null)
            {
                if (double.TryParse(txtOtherDistance.Text, out _otherTotalDistance))
                {
                    calculateDistance();
                }
            }
            
        }

        private void radSlow_CheckedChanged(object sender, EventArgs e)
        {
            _pace = _slowPace;
            calculateDistance();
        }

        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            _pace = _normalPace;
            calculateDistance();
        }

        private void radFast_CheckedChanged(object sender, EventArgs e)
        {
            _pace = _fastPace;
            calculateDistance();
        }

        private void radLiving_CheckedChanged(object sender, EventArgs e)
        {
            _undead = false;
            calculateDistance();
        }

        private void radUndead_CheckedChanged(object sender, EventArgs e)
        {
            _undead = true;
            calculateDistance();
        }

        private void radPlayerHealthy_CheckedChanged(object sender, EventArgs e)
        {
            _playerExhausted = false;
            calculateDistance();
        }

        private void radPlayerExhausted_CheckedChanged(object sender, EventArgs e)
        {
            _playerExhausted = true;
            calculateDistance();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
