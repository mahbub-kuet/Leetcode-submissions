/**
 * @param {number[][]} matrix
 * @return {number[]}
 */
var spiralOrder = function(matrix) {
    var spiralOderArray=[];
	var index=0;
    if(matrix.length===0)
	{
		return matrix;
	}
    if(matrix.length==1)
	{
		return matrix[0];
	}
	if(matrix[0].length==1)
	{		
		for(var i=0;i<matrix.length;i++)
			spiralOderArray[index++]=matrix[i][0];

		return spiralOderArray;
	}
	var rowmin=0;
    var rowmax=matrix.length-1;
    var colmax=matrix[0].length-1;
    var colmin=0;
    var a=matrix.length-1;
    while(a>0){
    	a--;
    	 for(var i=colmin;i<=colmax;i++){
    		spiralOderArray[index++]=matrix[rowmin][i];
    	}
    	rowmin++;
    	for(i=rowmin;i<=rowmax;i++){
    		spiralOderArray[index++]=matrix[i][colmax];
    	}
    	colmax--;
    	for(i=colmax;i>=colmin;i--){
    		spiralOderArray[index++]=matrix[rowmax][i];
    	}
    	rowmax--;
    	for(i=rowmax;i>=rowmin;i--){
    		spiralOderArray[index++]=matrix[i][colmin];
    	}
    	colmin++;
    }
    if(spiralOderArray.length> matrix.length*matrix[0].length){
     	spiralOderArray=spiralOderArray.slice(0,matrix.length*matrix[0].length);
     }

    return spiralOderArray;
};