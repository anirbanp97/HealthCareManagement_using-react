import {Link} from "react-router-dom";


function Navbar(){


return(

<nav>

<Link to="/medicines">
Medicines
</Link>


<Link to="/add-medicine">
Add Medicine
</Link>


<Link to="/sales">
Sales
</Link>


<Link to="/add-sale">
Add Sale
</Link>


</nav>


);

}

export default Navbar;