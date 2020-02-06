function replacer()
{
    let info = document.getElementById("info").value;

    let words = info.split(' ');

    words.forEach(word => {
        for (let i = 0; i < word.length; i++)
        {
            if (word.lastIndexOf(word[i]) != i)
            {
                info = replace(info, word[i]);
            }
        }
    });

    alert(info);

}


function replace(str, symbol)
{
    let result = str.split('');
    for (let i = 0; i < result.length; i++)
    {
        if (result[i] == symbol)
        {
            result[i] = '';
        }
    }
    
    return result.join('');
}