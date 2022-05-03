import React, { useEffect, useState } from 'react';
import 'antd/dist/antd.css';
import { Modal, Form, Input, Select } from 'antd';
import axios from 'axios';
import { SetSelectOption } from './helpful'

const uri = "http://localhost:5000/api/Schedule/";


const AddSchedule = ({ schedule, setSchedule, shifts, days, doctorid }) => {
    const [isModalVisible, setIsModalVisible] = useState(false);
    const [form] = Form.useForm();

    const showModal = () => {
        setIsModalVisible(true);
    };

    const handleOk = () => {
        setIsModalVisible(false);
    };

    const handleCancel = () => {
        setIsModalVisible(false);
    };

    const addSchedule = (newschedule) => setSchedule([...schedule, newschedule]);

    let shiftsFilter = [];
    for (let i = 0; i < shifts.length; i++) {
        shiftsFilter[i] = {
            text: shifts[i].timeofBegin + "-" + shifts[i].timeofEnd,
            value: shifts[i].id,
        }
    }

    const handleSubmit = (e) => {
        
        handleOk();
        let newshift = shifts.filter(i => i.id === e.shift)[0];
        let newday = days.filter(i => i.id === e.day)[0];
        axios.post(uri, { doctorId: doctorid, room:e.room, shift:newshift, dayofWeekNavigation: newday})
            .then((response) => {
                response.status = 201 ? addSchedule(response.data) : null;
            })
            .catch(console.error);
    };

    return (
        <div>
            <br />
            <button onClick={showModal} className="btn btn-success mb-1">Создать</button>
            <Modal title="Добавить рабочую смену" visible={isModalVisible} onOk={form.submit} onCancel={handleCancel}>
                <Form form={form} onFinish={handleSubmit}>
                    <Form.Item
                        label="Кабинет"
                        name="room"
                        rules={[
                            {
                                required: true,
                                message: 'Введите кабинет',
                            },
                        ]}
                    >
                        <Input />
                    </Form.Item>
                    <Form.Item
                        name="shift"
                        label="Смена"
                        rules={[
                            {
                                required: true,
                                message: 'Выберите смену!',
                            },
                        ]}
                    >
                        <Select>
                            {shiftsFilter.map(({ value, text }) => (
                                <Select.Option value={value}>{text}</Select.Option>
                            ))}
                        </Select>
                    </Form.Item>

                    <Form.Item
                        name="day"
                        label="День недели"
                        rules={[
                            {
                                required: true,
                                message: 'Выберите день недели!',
                            },
                        ]}
                    >
                        <Select>
                            {days.map(({ id, dayOfWeek }) => (
                                <Select.Option value={id}>{dayOfWeek}</Select.Option>
                            ))}
                        </Select>
                    </Form.Item>

                </Form>
            </Modal>
        </div>
    );
};

export default AddSchedule;