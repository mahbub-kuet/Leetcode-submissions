/**
 * @param {string} a
 * @param {string} b
 * @return {string}
 */
var addBinary = function(a, b) {
    
if(a.length!=b.length)
{
	var dif=a.length-b.length;
	var s="";
		for(var i=0;i<Math.abs(dif);i++)
            s=s+"0";
	dif>0? b=s+b:a=s+a;	
}
//document.write(a+"<br/>"+b);
var resultstring="",carry="0";
for(i=a.length-1;i>=0;i--){
      if(a[i]=="0" && b[i]=="0")
      {
      	resultstring=carry+resultstring;
      	carry="0"
      }

      if(a[i]=="1" && b[i]=="1")
      {      	
      	if(carry=="0"){
      		resultstring="0"+resultstring;
      		carry="1";
      	} 
      	else{
      		resultstring="1"+resultstring;
      		carry="1";
      	} 
      }

      if( (a[i]=="0" && b[i]=="1") || (a[i]=="1" && b[i]=="0")) 
      {      	
      	if(carry=="0"){
      		resultstring="1"+resultstring;
      		carry="0";
      	} 
      	else{
      		resultstring="0"+resultstring;
      		carry="1";
      	} 
      }      	
}
if(carry=="1")
  resultstring=carry+resultstring;
  
  return resultstring;
  
}