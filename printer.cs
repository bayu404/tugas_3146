using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace ThesuperComputer
{
    class printer
{
    private String brand;
    private String series;
    private int ppm;

    public String getBrand(){
        return this.brand;
    }
    public int getSeries(){
        return this.series;
    }
    public int  getPpm(){
        return this.ppm;
    }
    public override String ToString()
    {
        return $'Printer brand :
{this.brand} ; Printer series:
{this.series} ; Printer paper per minutes(ppm):{this.ppm}";
        }
    }
}
