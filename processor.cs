using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ThesuperComputer
{
    class processor
{
    private String series;
    private int core;
    private int cache;

    public processor(){

    }

    public void setseries(String series){
        this.series =series;
    }
    public String getSeries(){
        return this.series;
    }
    public void setCore(){
        return this.core;
    }
    public int  getCore(){
        return this.core;
    }
    public void setCache(int cache){
        this.cache = cache;
    }
    public  getCache(){
        return this.cache;
    }
    public override StringTostring()
    {
        return $'Processor series:
{this.series} ; processor core:
{this.core} ; Processor cache:
{this.cache}";
        }
    }
}