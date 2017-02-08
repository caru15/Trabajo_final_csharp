using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajo_final_csharp.App_Start
{
    public class FacturaReal
    {
        private int IdFactura;
        private DateTime fechaEmsion;
        private DateTime fechaMovimiento;
        private string Tipo;//si es cobro o pago
        private Double Monto;
        private string Moneda;//dolar o peso
        private string Modo;//modo de pago si es efectivo con cheques 
        private int IdNota;
        private int IdCheque;
        private string Destinatario;
        private string Originante;

        //CONSTRUCTORES
        public FacturaReal() { }

        public FacturaReal(int IF,DateTime FE, DateTime FM, string ti,Double mon,string mone,string mod,int IN, int IC,string des,string ori)
        {
            this.IdFactura = IF;
            this.fechaEmsion = FE;
            this.fechaMovimiento = FM;
            this.Tipo = ti;
            this.Monto = mon;
            this.Moneda = mone;
            this.Modo = mod;
            this.IdNota = IN;
            this.IdCheque = IC;
            this.Destinatario = des;
            this.Originante = ori;
        }
        public int SGIdFactura
        {
            get { return IdFactura; }
            set { IdFactura = value; }
        }

        public DateTime SGFechaEmi
        {
            get { return fechaEmsion; }
            set { fechaEmsion = value; }
        }

        public DateTime SGFechaMov
        {
            get { return fechaMovimiento; }
            set { fechaMovimiento = value; }
        }
        public string SGTipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        public Double SGMonto
        {
            get { return Monto; }
            set { Monto = value; }
        }
        public string SGMoneda
        {
            get { return Moneda; }
            set { Moneda = value; }
        }
        public string SGModo
        {
            get { return Modo; }
            set { Modo = value; }
        }
        public int SGIdNota
        {
            get { return IdNota; }
            set { IdNota = value; }
        }
        public int SGIdCheque
        {
            get { return IdCheque; }
            set { IdCheque= value; }
        }
        public string SGDestinatario
        {
            get { return Destinatario; }
            set { Destinatario = value; }
        }
        public string SGOriginante
        {
            get { return Originante; }
            set { Originante = value; }
        }
        public string FormatoFecha(DateTime fe)
        {
            return fe.ToString("dd/MM/yyyy");
        }
        public int Tamaño
        { get { return (8+ FormatoFecha(SGFechaEmi).Length * 2+ FormatoFecha(SGFechaMov).Length * 2+SGTipo.Length*2+16+SGMoneda.Length*2+SGModo.Length*2+8+8+SGDestinatario.Length*2+SGOriginante.Length*2); } }
    }
}