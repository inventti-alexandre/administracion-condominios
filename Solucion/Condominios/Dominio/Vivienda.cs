﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Condominios.Dominio
{
    public class Vivienda
    {
        private int _NumVivienda;
        private String _Ubicacion;
        private int _Numero;
        private int _Metraje;
        private String _Tipo;
        private Residente _Residente;

        public int NumVivienda
        {
            get { return _NumVivienda; }
            set { _NumVivienda = value; }
        }

        public String Ubicacion
        {
            get { return _Ubicacion; }
            set { _Ubicacion = value; }
        }

        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public int Metraje
        {
            get { return _Metraje; }
            set { _Metraje = value; }
        }

        public String Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        public Residente Residente
        {
            get { return _Residente; }
            set { _Residente = value; }
        }
    }
}