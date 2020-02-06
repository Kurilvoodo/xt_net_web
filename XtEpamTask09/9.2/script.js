function Caclculator()
{
    let info = document.getElementById("info").value;
    let infoParse = info.match(/(\*|\+|\/|\-{1}) {0,1}[1-9]{0,}(\.{0,1}\d+)|[1-9]{0,}/g);

    let result = Number(infoParse[0]);

    infoParse.forEach(action => {
        switch(action[0]) {
            case '+':
                result += Number(action.match(/[1-9]{0,}(\.{0,1}\d+)/g));
                console.log(result);
                break;
            case '-':  
                result -= Number(action.match(/[1-9]{0,}(\.{0,1}\d+)/g));
                console.log(result);
                break;
            case '*':
                result *= Number(action.match(/[1-9]{0,}(\.{0,1}\d+)/g));
                console.log(result);
                break;
            case '/':
                result /= Number(action.match(/[1-9]{0,}(\.{0,1}\d+)/g));
                console.log(result);
                break;
            default:
                break;
          }
    });
    alert(String(result).match(/[1-9]{0,}(\.{0,1}\d{1,2})/g)[0]);
}