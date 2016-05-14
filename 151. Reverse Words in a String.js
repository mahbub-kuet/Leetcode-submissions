var reverseWords = function(str) {
    return str.split(' ').reverse().filter(Boolean).join(' ');
};