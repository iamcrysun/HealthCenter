import React from 'react';
import * as ReactDOMClient from 'react-dom/client';
import ReactDOM from 'react-dom';
//import { InitializeAdminTheme, InitializeFooter } from './adminTheme.jsx';
import { InitializeSchedule } from './schedule.jsx';
import { InitializeFooter } from './footer.jsx';
import { InitializeHeader } from './Header.jsx';

{
    //ReactDOMClient.createRoot(document.getElementById('header')).render(<InitializeAdminTheme />);
    ReactDOMClient.createRoot(document.getElementById('app')).render(<InitializeSchedule />);
    ReactDOMClient.createRoot(document.getElementById('footer')).render(<InitializeFooter />);
    ReactDOMClient.createRoot(document.getElementById('header')).render(<InitializeHeader />);
}