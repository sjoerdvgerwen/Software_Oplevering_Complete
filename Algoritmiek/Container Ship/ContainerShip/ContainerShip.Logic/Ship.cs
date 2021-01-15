using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainerShip.Logic
{
    public class Ship
    {
        public int ShipWeight { get; set; }
        public int AmountOfRows { get; set; }
        public int AmountOfColumns { get; set; }

        public List<Row> Rows = new List<Row>();

        public override string ToString()
        {
            Console.WriteLine("Schip met max gewicht van " + this.ShipWeight);
            foreach (var row in Rows)
            {
                Console.WriteLine(row.ToString());
            }

            return "";
        }

        public Ship(int shipWeight, int amountOfRows, int amountOfColumns)
        {
            ShipWeight = shipWeight;
            AmountOfRows = amountOfRows;
            AmountOfColumns = amountOfColumns;

            Rows = BuildRow();
        }

        public List<Row> BuildRow()
        {
            List<Row> rows = new List<Row>();

            for (int i = 0; i < AmountOfRows; i++)
            {
                Row row = new Row(i, AmountOfColumns);
                rows.Add(row);
            }

            return rows;
        }

        public bool FillRows(Container container)
        {
            foreach (Row row in Rows)
                {
                    if (row.TryAddContainer(container))
                    {
                        return true;
                    }
                }
            return false;
        }
    }
}