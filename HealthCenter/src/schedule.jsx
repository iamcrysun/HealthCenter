import React, { useEffect, useState } from 'react';
import axios from 'axios';
import 'antd/dist/antd.css';
import ReactDOM from 'react-dom';
import * as ReactDOMClient from 'react-dom/client';
import ScheduleTable from './scheduleTable'
import AddSchedule from './AddSchedule'
import { Modal, Form, Input, Select } from 'antd';


export function InitializeSchedule() { return App(); }
const { Option } = Select.Option;

const App = () => {


    const [schedule, setSchedule] = useState([]);
    const [days, setDays] = useState([]);
    const [shifts, setShifts] = useState([]);
    const [doctors, setDoctors] = useState([]);
    const [doctor, setDoctor] = useState(0);

    useEffect(() => {
        axios({
            "method": "GET",
            "url": "http://localhost:5000/api/Doctor/",
            "mode": 'no-cors',
            "headers": {
                'Access-Control-Allow-Origin': "http://localhost:5000",
                'Access-Control-Allow-Credentials': "true",
                "content-type": "application/json",
            }
        })
            .then((response) => {
                console.log(response.data);
                setDoctors(response.data);
            })
            .catch((error) => {
                console.log(error);
            });
    }, [setDoctors]);


    useEffect(() => {
        axios({
            "method": "GET",
            "url": "http://localhost:5000/api/Shift/",
            "mode": 'no-cors',
            "headers": {
                "content-type": "application/json",
            }
        })
            .then((response) => {
                setShifts(response.data);
            })
            .catch((error) => {
                console.log(error);
            });
    }, [setShifts]);


    useEffect(() => {
        axios({
            "method": "GET",
            "url": "http://localhost:5000/api/Day/",
            "mode": 'no-cors',
            "headers": {
                "content-type": "application/json",
            }
        })
            .then((response) => {
                setDays(response.data);
            })
            .catch((error) => {
                console.log(error);
            });
    }, [setDays]);



    const SetSchedule = (id) => {
        setDoctor(id);
        axios({
            "method": "GET",
            "url": "http://localhost:5000/api/Doctor/"+id,
            "mode": 'no-cors',
            "headers": {
                "content-type": "application/json",
            }
        })
            .then((response) => {
                console.log(response.data.schedules);
                setSchedule(response.data.schedules);
            })
            .catch((error) => {
                console.log(error);
            });
    }

    return (
        <div className="container">
            <h1>Доктор</h1>
            
            <Select onChange={SetSchedule} style={{ width: "50%" }}>

                {doctors.map(({ id, fullName }) => (
                    <Select.Option value={id} key={id}>{fullName}</Select.Option>
                ))}
                </Select>
             
            <AddSchedule
                schedule={schedule}
                setSchedule={setSchedule}
                shifts={shifts}
                days={days}
                doctorid={doctor}
            />
                
            <ScheduleTable
            schedule={schedule}
                setSchedule={setSchedule}
                shifts={shifts}
                days={days} />
        </div>
    );
};