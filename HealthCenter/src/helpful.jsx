import React, { useEffect, useState } from 'react';
import axios from 'axios';
import ReactDOM from 'react-dom';

const setOption = ({ value, text, id }) => {
    /*console.log(text);*/
    if (value === id) {
        return <option key={value} value={value} selected>{text}</option>
    }
    else {
        return <option key={value} value={value}>{text}</option>
    }
}

const setSelectOption = ({ value, text, id }) => {
    /*console.log(text);*/
    if (value === id) {
        return <Select.Option key={value} value={value} selected>{text}</Select.Option>
    }
    else {
        return <Select.Option key={value} value={value}>{text}</Select.Option>
    }
}

export function SetOption(value, text, id) { return setOption(value, text, id); }
export function SetSelectOption(value, text, id) { return setSelectOption(value, text, id); }