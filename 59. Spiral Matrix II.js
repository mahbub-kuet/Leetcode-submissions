/**
 * @param {number} n
 * @return {number[][]}
 */
var generateMatrix = function(n) {
    if (n==0)
       return [];
    
    if (n==1)
    return [[1]];
    var matrix=new Array(n);
	for(var i=0;i<n;i++){
		matrix[i]=new Array(n);
	}
	var index=1;
    var rowmin=0;
    var rowmax=n-1;
    var colmax=n-1;
    var colmin=0;
    var a=n-1;
    while(a>0){
    	a--;
    	 for( i=colmin;i<=colmax;i++){
    		matrix[rowmin][i]=index++;
    	}
    	rowmin++;
    	for(i=rowmin;i<=rowmax;i++){
    		matrix[i][colmax]=index++;
    	}
    	colmax--;
    	for( i=colmax;i>=colmin;i--){
    		matrix[rowmax][i]=index++;
    	}
    	rowmax--;
    	for( i=rowmax;i>=rowmin;i--){
    		matrix[i][colmin]=index++;
    	}
    	colmin++;
    }
    return matrix;
};