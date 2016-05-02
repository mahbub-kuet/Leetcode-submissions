var rotate = function(matrix) {
    var rotatedmatrix = [];
    var length = matrix.length;
    for(var i=0; i<length; ++i){     
        rotatedmatrix[i] = [];
    }
    for(i=0; i<length; ++i){         
        for(var j=0; j<length; ++j){
            rotatedmatrix[j][length-i-1] = matrix[i][j];
        }
    }
     for(i=0; i<length; ++i){         // step 3
        for(j=0; j<length; ++j){
            matrix[i][j] = rotatedmatrix[i][j];
        }
    }
};