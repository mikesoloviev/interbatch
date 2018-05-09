namespace Submark  {
    public class Stylesheet {
        public static string Style = @"
body {
    font-family: 'Segoe UI', 'Helvetica Neue', Helvetica, Arial, sans-serif;
    font-size: 14px;
    line-height: 1.5;
    background-color: white;
    color: #202020;
    margin-top: -10px;
    margin-left: 10px;
}
h1, h2, h3, h4 {
    margin: 20px 0px 10px 0px;
    padding: 0;
}
h1, h2, h3 {
    margin-bottom: 15px;
    border-bottom: 1px solid #C0C0C0;
}
h1 {
    font-size: 24px;
}
h2 {
    font-size: 20px;
}
h3 {
    font-size: 18px;
}
h4 {
    font-size: 16px;
}
hr {
    border: 0 none;
    color: #C0C0C0;
    height: 1px;
    padding: 0;
}
p {
    margin-top: 10px;
    margin-bottom: 10px;
}
p + p {
    margin-top: 0px;
}
ul {
    margin-left: 15px;
    margin-top: 10px;
    margin-bottom: 10px;
}
ul ul {
    margin-top: 0px;
    margin-bottom: 0px;
}
table {
   border-collapse: collapse;
   margin-top: 20px;
   margin-bottom: 20px;
}
tr.head {
    background-color: #F0F0F0;
}
tr.odd {
    background-color: #FFFFFF;
}
tr.even {
    background-color: #F8F8F8;
}
th, td {
    border: 1px solid #E0E0E0;
    padding: 6px;
}
th {
    font-weight: bold;
    text-align: center;
}
td {
    text-align: left;
}
td.center {
    text-align: center;
}
td.right {
    text-align: right;
}
blockquote {
    margin-left: 10px;
    padding-left: 10px;
    color: #606060;
    border-left: 4px solid #E0E0E0;
}
pre, code {
    font-family: Consolas, Menlo, Courier, monospace;
    font-size: 13px;
    color: #000020;
    background-color: #F0F0F0;
}
pre {
    padding: 10px;
    border: 1px solid #E0E0E0;
    border-radius: 4px;
    overflow: auto;
}
code {
    padding: 2px 5px;
}
b {
    color: #586068;
}
i {
    color: #004060;
}
a {
    color: #4080C0;
    text-decoration: none;
}

";
    }
}
